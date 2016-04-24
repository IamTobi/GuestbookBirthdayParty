using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;
using System;

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
        [Java.Interop.Export("onBtnClicked")]
        public void onBtnClicked(View v)
        {
           
        }


    }
}
