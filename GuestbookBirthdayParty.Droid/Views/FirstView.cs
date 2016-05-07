using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "Joyster",ScreenOrientation = ScreenOrientation.Landscape, Icon = "@android:color/transparent")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
           
        }
        public override void OnBackPressed()
        {
            
        }

    }
}
