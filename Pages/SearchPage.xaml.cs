using RealEstateApp.Services;

namespace RealEstateApp.Pages;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}

    private void ImgBackBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }

    private async void SbProperty_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue == null) return;
        var propertiesResult = await ApiService.FindProperties(e.NewTextValue);
        CvSearch.ItemsSource = propertiesResult;
    }
}