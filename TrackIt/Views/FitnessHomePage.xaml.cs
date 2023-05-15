using TrackIt.ViewModels;

namespace TrackIt;

public partial class FitnessHomePage : ContentPage
{
	public FitnessHomePage()
	{
		InitializeComponent();
	}

	private void MyWorkoutBtn_Clicked(object sender, EventArgs e)
	{	 
		Shell.Current.GoToAsync(nameof(ProfilePage));    
	}

    private void ExercisesBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ExercisesPage());
	}

	private void MyProgressBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MyProgressPage());
	}

	private void WeeklyBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new WeeklyPage());
	}
}