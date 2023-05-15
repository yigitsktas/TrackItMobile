﻿namespace TrackIt;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(FitnessHomePage), typeof(FitnessHomePage));
		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
	}
}
