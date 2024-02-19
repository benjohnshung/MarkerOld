using Library.MarkerApp.Models;

namespace Library.MarkerApp.Services
{
    public class StudentService
    {
        private IList<Student> students;
        private string? query;
        private static object _lock = new object();
        private static StudentService? instance;
        public static StudentService Current
        {
            get
            {
                lock(_lock)
                {
                    if (instance == null)
                    {
                        instance = new StudentService();
                    }
                }

                return instance;
            }
        }
        public IEnumerable<Student> Students
        {
            get
            {
                return students.Where(
                c =>
                        (c.Name ?? string.Empty).ToUpper().Contains(query ?? string.Empty));
            }
        }

        private StudentService()
        {
            students = new List<Student>();
        }

        public IEnumerable<Student> Search(string query)
        {
            this.query = query;
            return Students;
        }

        public void Add(Student studentToAdd)
        {
            students.Add(studentToAdd);
        }

        public void Delete(Student studentToDelete)
        {
            students.Remove(studentToDelete);
        }
    }
}
