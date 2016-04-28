using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "View for Finish")]
    public class FinishView:MvxActivity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FinishView);
        }

        public override void OnBackPressed()
        {
            
        }
    }
}
