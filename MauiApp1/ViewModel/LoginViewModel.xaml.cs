using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Pages;

namespace MauiDemo.ViewModel;

public partial class LoginViewModel : ObservableObject
{
	//Annotation => การระบุ
	[ObservableProperty]
	string username = "";
	[ObservableProperty]
	string password = "";
	[ObservableProperty]
	string route = nameof(RegisterPage);

	[RelayCommand]
	void Login()
	{
		System.Diagnostics.Debug.Print("Username: " + Username);
		System.Diagnostics.Debug.Print("Password: " + Password);
		System.Diagnostics.Debug.Print("XXX");

	}
	[RelayCommand]
	async Task GoToPage(string page){
		await Shell.Current.GoToAsync(page);
	}

}


