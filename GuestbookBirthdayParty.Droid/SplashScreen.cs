using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid
{
    [Activity(
        Label = "GuestbookBirthdayParty.Droid"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Landscape)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
