using TrackIt.Interfaces;
using TrackIt.Services;

namespace TrackIt;

public partial class RegisterPage : ContentPage
{
    readonly IRegisterService _registerService = new RegisterService();

    public RegisterPage()
	{
		InitializeComponent();
	}

    private async void RegisterBtn_Clicked(object sender, EventArgs e)
    {
		string username = nickname.Text;
		string eMail = email.Text;
		string passwrd = password.Text;

		if (username != null || eMail != null || passwrd != null)
		{
            var result = await _registerService.Register(username, eMail, passwrd);

			if (result == true)
			{
                await Shell.Current.GoToAsync(nameof(FitnessHomePage));
			}
            else
			{
                await DisplayAlert("Warning", "User already exists!", "Ok");
            }
		}
        else
        {
            await DisplayAlert("Warning", "Fill all!", "Ok");
        }
    }
}