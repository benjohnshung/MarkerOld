using Library.MarkerApp.Models;
using Library.MarkerApp.Services;

namespace MAUI.Marker.ViewModels
{
    class AddCourseViewModel()
    {
        course = new Course();
    }

    private Course course;

    public void AddCourse(Shell s)
    {
        CourseService.Current.Add(course);
        s.GoToAsync("//MainPage");
    }
}
