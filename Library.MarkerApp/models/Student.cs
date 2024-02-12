using Library.MarkerApp.Models;

namespace Library.MarkerApp.models
{
    public enum ClassificationType { Freshman, Sophomore, Junior, Senior }
    public class Student
    {
        public string? Name { get; set; }
        public ClassificationType? Classification { get; set; }
        public List<int>? Grades { get; set; }
        public Guid ID { get; set; }
        public IList<Course>? CurrentCourses { get; set; }


        public Student()
        {

        }

        public override string ToString()
        {
            return $"({ID}) {Classification} - {Name}";
        }

    }
}
