using Library.MarkerApp.Models;

namespace Library.MarkerApp.Models
{
    public class Course
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IList<Student>? Roster { get; set; }
        public IList<Assignment>? Assignments { get; set; }
        public IList<Module>? Modules { get; set; }

        public Course()
        {

        }

        public override string ToString()
        {
            return $"({Code}) {Name}";
        }
    }
}