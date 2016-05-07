using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "Frage #1", ScreenOrientation = ScreenOrientation.Landscape, Icon = "@android:color/transparent")]
    public class FirstQuestionView : MvxActivity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstQuestionView);
        }

        public override void OnBackPressed()
        {

        }
    }
}
