using Microsoft.Extensions.DependencyInjection;
using RealEstateApp.Pages;

namespace RealEstateApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegisterPage();
        }
    }
}