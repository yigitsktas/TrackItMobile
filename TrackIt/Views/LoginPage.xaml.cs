using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TrackIt.Interfaces;
using TrackIt.Model;
using TrackIt.Services;

namespace TrackIt;

public partial class LoginPage : ContentPage
{
	readonly ILoginService _loginService = new LoginService();

	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
		string username = email.Text;
		string passwrd = password.Text;

		if (username == null || passwrd == null)
		{
			return;
		}

		bool isValid = await _loginService.Login(username, passwrd);	
		
		if (isValid == true) 
		{
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
        else
		{
			await DisplayAlert("Login Error", "Username or Password is incorrect!", "Close");
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
    }
}