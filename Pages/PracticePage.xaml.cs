namespace RealEstateApp.Pages;

public partial class PracticePage : ContentPage
{
    public PracticePage()
    {
        InitializeComponent();
        LoadCities();
    }

    // Data giả cho Bài 5 — thực tế sẽ gọi ApiService.GetXxx()
    private void LoadCities()
    {
        var cities = new List<CityItem>
        {
            new CityItem { Name = "TP.HCM" },
            new CityItem { Name = "Hà Nội" },
            new CityItem { Name = "Đà Nẵng" },
            new CityItem { Name = "Nha Trang" },
            new CityItem { Name = "Phú Quốc" },
        };
        CvCities.ItemsSource = cities;
    }
}

// Model nhỏ chỉ dùng cho bài tập này
public class CityItem
{
    public string Name { get; set; }
}
