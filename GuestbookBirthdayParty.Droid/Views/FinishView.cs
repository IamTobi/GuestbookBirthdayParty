using Android.App;
using Android.OS;
using Android.Views;
using GuestbookBirthdayParty.Core.ViewModels;
using MvvmCross.Droid.Views;
using System;

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
