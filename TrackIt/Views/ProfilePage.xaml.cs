using TrackIt.Helpers;
using TrackIt.Model;
using TrackIt.Services;
using TrackIt.ViewModels;

namespace TrackIt;

public partial class ProfilePage : ContentPage
{
    public ProfileViewModel _viewModel;

	public ProfilePage(ProfileViewModel vm)
	{
		InitializeComponent();
        _viewModel = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            _viewModel.GetProfileCommand.Execute(null);
        }
    }
}