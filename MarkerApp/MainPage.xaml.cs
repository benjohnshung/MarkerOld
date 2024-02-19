namespace MarkerApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            // BindingContext = new MainViewModel();
        }

        //private void OnAddCourse_Clicked(object sender, EventArgs e)
        //{
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        private void AddCourseBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AddStudentBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
