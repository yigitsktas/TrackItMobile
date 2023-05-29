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
            builder.Services.AddSingleton<ProfilePage>();
            builder.Services.AddSingleton<TrackIt.Views.Health.LogsPage>();

            return builder;
        }
    }
}
