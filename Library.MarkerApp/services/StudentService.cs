using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.MarkerApp.models;

namespace Library.MarkerApp.services
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
                        c.Name.ToUpper().Contains(query ?? string.Empty));
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

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Delete(Student studentToDelete)
        {
            students.Remove(studentToDelete);
        }
    }
}
