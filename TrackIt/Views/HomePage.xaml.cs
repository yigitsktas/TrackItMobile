using TrackIt.ViewModels;

namespace TrackIt;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private void ProfileBtn_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ProfilePage));
	}

	private void HealthLogBtn_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(TrackIt.Views.Health.LogsPage));
	}
}