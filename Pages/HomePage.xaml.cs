using RealEstateApp.Services;

namespace RealEstateApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        LblUsername.Text = "Hi " + Preferences.Get("username", string.Empty);
        GetCategories();
        GetTrendingProperties();
    }

    private async void GetTrendingProperties()
    {
        var properties = await ApiService.GetTrendingProperties();
        CvTopPicks.ItemsSource = properties;
    }

    private async void GetCategories()
    {
        var categories = await ApiService.GetCategories();
        CvCategories.ItemsSource = categories;
    }
}