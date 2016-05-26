using System;
using GuestbookBirthdayParty.Core.Services;
using GuestbookBirthdayParty.Core.ViewModels;
using Java.IO;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace GuestbookBirthdayParty.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<FirstViewModel>());
        }

        public static implicit operator App(File v)
        {
            throw new NotImplementedException();
        }
    }
}
