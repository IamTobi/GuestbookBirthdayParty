using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "Frage #3", ScreenOrientation = ScreenOrientation.Landscape, Icon = "@android:color/transparent")]
    public class ThirdQuestionView : MvxActivity
    {
        

        protected override void OnCreate(Bundle bundle) 
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ThirdQuestionView);
        }

        public override void OnBackPressed()
        {

        }
    }
}
