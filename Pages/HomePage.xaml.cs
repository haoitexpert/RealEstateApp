namespace RealEstateApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		LblUsername.Text = "Hi " + Preferences.Get("username", string.Empty);
	}
}