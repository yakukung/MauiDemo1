namespace MauiApp1.Pages;

public partial class ViewsPage : ContentPage
{
	public ViewsPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("Hello Man!!!!!");
		// DisplayAlert("Alert", "สวัสดี", "ปิด");
		await Navigation.PopAsync();
;    }
}