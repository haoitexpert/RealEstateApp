using RealEstateApp.Services;

namespace RealEstateApp.Pages;

public partial class PropertyDetailPage : ContentPage
{
    private string phoneNumber;
    public PropertyDetailPage(int propertyId)
	{
		InitializeComponent();
		GetPropertiesDetail(propertyId);
	}

    private async void GetPropertiesDetail(int propertyId)
    {
        try
        {
            var property = await ApiService.GetPropertyDetail(propertyId);
            if (property == null)
            {
                await DisplayAlert("Error", "Property not found.", "OK");
                return;
            }

            LblPrice.Text = "$ " + property.Price;
            LblDescription.Text = property.Detail;
            LblAddress.Text = property.Address;
            ImgProperty.Source = property.FullImageUrl;
            phoneNumber = property.Phone;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void TapMessage_Tapped(object sender, TappedEventArgs e)
    {
        var message = new SmsMessage("Hi! I am interested in your property", phoneNumber);
        Sms.ComposeAsync(message);
    }

    private void TapCall_Tapped(object sender, TappedEventArgs e)
    {
        PhoneDialer.Open(phoneNumber);
    }

    private void ImgbackBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}