using ToDoApp.ViewModels;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel VM { get; set; }

        public MainPage()
        {
            InitializeComponent();
            VM = new MainViewModel();
            this.BindingContext = VM;
        }
    }

}
