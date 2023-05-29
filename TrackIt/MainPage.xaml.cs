namespace TrackIt;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }

    private void RegisterBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new RegisterPage());
    }

	private void Fitness_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new HomePage());
	}
}

