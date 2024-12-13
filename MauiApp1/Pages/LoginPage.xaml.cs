namespace MauiApp1.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
  private async void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine(uname.Text);
		System.Diagnostics.Debug.WriteLine(pwd.Text);
		if(uname.Text == "admin" && pwd.Text == "1234"){
			await Navigation.PushAsync(new ViewsPage());
		}else{
		 await	DisplayAlert("Error", "Username or Password incorrect", "Close");
		}
    }

    private async void Tapped(object sender, TappedEventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("Tapped");
		await Shell.Current.GoToAsync(nameof(ForgetPasswordPage));
    }
}