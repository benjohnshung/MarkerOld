using Library.MarkerApp.Models;
using Library.MarkerApp.Services;

namespace MarkerApp.viewmodels
{
    class AddCourseViewModel
    {
        public AddCourseViewModel()
        {
            course = new Course();
        }


        private Course course;
        public void AddCourse(Shell s)
        {
            CourseService.Current.Add(course);
            s.CurrentItem.CurrentItem = new MainPage();
        }
    }
}
