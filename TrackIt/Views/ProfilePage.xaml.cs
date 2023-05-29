using TrackIt.Helpers;
using TrackIt.Interfaces;
using TrackIt.Model;
using TrackIt.Services;
using TrackIt.ViewModels;

namespace TrackIt;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		
		var member = MemberService.GetMember();

		if (member != null)
		{
			UserName.Text = member.Username;
			EMail.Text = member.EMail;
			email.Text = member.EMail;
		}
		else
		{
			UserName.Text = "";
			EMail.Text = "";
		}
	}
}