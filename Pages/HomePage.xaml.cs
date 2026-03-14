using RealEstateApp.Services;

namespace RealEstateApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		LblUsername.Text = "Hi " + Preferences.Get("username", string.Empty);
		GetCategories();
	}

    private async void GetCategories()
    {
		var categories = await ApiService.GetCategories();
		CvCategories.ItemsSource = categories;
    }
}