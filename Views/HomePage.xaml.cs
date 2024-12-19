using Microsoft.Maui.Controls;
using Gift_Exchange.ViewModels;

namespace Gift_Exchange.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
