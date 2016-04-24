using Android.App;
using Android.OS;
using Android.Views;
using GuestbookBirthdayParty.Core.ViewModels;
using MvvmCross.Droid.Views;
using System;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "View for SecondQuestion")]
    public class SecondQuestionView : MvxActivity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondQuestionView);
        }
        public override void OnBackPressed()
        {

        }
    }
}
