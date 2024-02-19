using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Marker.ViewModels;

namespace MAUI.Marker.Views;

public partial class AddCourseView : ContentPage
{
    public AddCourseView()
    {
        InitializeComponent();
        BindingContext = new AddCourseViewModel();
    }

    private void OkClicked(object sender, EventArgs e)
    {
        (BindingContext as AddCourseViewModel).AddCourse(Shell.Current);
    }
}

