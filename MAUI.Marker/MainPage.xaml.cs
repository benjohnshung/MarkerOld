namespace MAUI.Marker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        private void AddCourseBtn_Clicked(object sender, EventArgs e)
        {
            AddCourseBtn.Text = "Add Course button clicked";
            SemanticScreenReader.Announce(AddCourseBtn.Text);
        }
    }

}
