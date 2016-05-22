using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "Stats", ScreenOrientation = ScreenOrientation.Landscape, Icon = "@android:color/transparent")]
    public class StatsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.StatsView);
        }
    }
}