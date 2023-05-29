
namespace TrackIt;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
		Routing.RegisterRoute(nameof(MyExercisesPage), typeof(MyExercisesPage));
		Routing.RegisterRoute(nameof(TrackIt.Views.Health.LogsPage), typeof(TrackIt.Views.Health.LogsPage));
	}
}
