namespace MauiApp1.Pages;

public partial class ForgetPasswordPage : ContentPage
{
	public ForgetPasswordPage()
	{
		InitializeComponent();

	}
	 private async void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("back");
		await Navigation.PopAsync();
    }
}