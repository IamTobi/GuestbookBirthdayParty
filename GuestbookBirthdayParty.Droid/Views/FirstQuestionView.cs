using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "View for FirstQuestionView")]
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
