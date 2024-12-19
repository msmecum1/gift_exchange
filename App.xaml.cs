using Microsoft.Maui.Controls; // Add this using directive
using Application = Microsoft.Maui.Controls.Application; // Add this alias directive

namespace Gift_Exchange
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
