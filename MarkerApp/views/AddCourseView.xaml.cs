using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkerApp.viewmodels;

namespace MarkerApp.Views;

public partial class AddCourseView : ContentPage
{
    public AddCourseView()
    {
        InitializeComponent();
        BindingContext = new AddCourseViewModel();
    }

    private void Ok_Clicked(object sender, EventArgs e)
    {
        (BindingContext as AddCourseViewModel).AddCourse(Shell.Current);
    }
}
