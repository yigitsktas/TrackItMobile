using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrackIt.Helpers;
using TrackIt.Interfaces;
using TrackIt.Model;
using TrackIt.Services;

namespace TrackIt.ViewModels
{
    public partial class ProfileViewModel : BaseViewModel
    {
        public readonly IMemberService _memberService;

        public Member Member { get; set; }

        public ProfileViewModel(IMemberService memberService) 
        {
            _memberService = memberService;
        }

        [RelayCommand]
        public async Task GetProfile()
        {
            var member = await _memberService.GetMember();
            Member = member;
        }
    }
}
