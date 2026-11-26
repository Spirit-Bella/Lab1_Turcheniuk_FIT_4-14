using Lab1_Turcheniuk_FIT_4_14.ViewModels;

namespace Lab1_Turcheniuk_FIT_4_14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}
