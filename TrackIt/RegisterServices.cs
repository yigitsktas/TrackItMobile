using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackIt.Interfaces;
using TrackIt.Services;
using TrackIt.ViewModels;

namespace TrackIt
{
    public static class RegisterServices
    {
        public static MauiAppBuilder AddRegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IMemberService, MemberService>();
            builder.Services.AddSingleton<ProfileViewModel>();
            builder.Services.AddSingleton<ProfilePage>();

            return builder;
        }
    }
}
