using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "View for ThirdQuestion")]
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
