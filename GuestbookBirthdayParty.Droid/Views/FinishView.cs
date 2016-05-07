using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Locations;
using Android.OS;
using Android.Provider;
using Android.Widget;
using GuestbookBirthdayParty.Core;
using Java.IO;
using Java.Util;
using MvvmCross.Droid.Views;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;

namespace GuestbookBirthdayParty.Droid.Views
{
    [Activity(Label = "Gästebucheintrag", ScreenOrientation = ScreenOrientation.Landscape, Icon = "@android:color/transparent")]
    public class FinishView : MvxActivity
    {
        public static File File;
        public static File Dir;
        public static ImageView ImageView;
        public static Bitmap Bitmap;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FinishView);

            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();
                var button = FindViewById<Button>(Resource.Id.takeThePictureButton);
                ImageView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Click += TakeAPicture;
            }
        }

        private static void CreateDirectoryForPictures()
        {
            Dir = new File(
                Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures),"BirthdayPics");
            if (!Dir.Exists())
            {
                Dir.Mkdirs();
            }
        }

        private bool IsThereAnAppToTakePictures()
        {
            var intent = new Intent(MediaStore.ActionImageCapture);
            var availableActivities = PackageManager.QueryIntentActivities(intent,
                PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);

            File = new File(Dir,String.Format("photo_{0}.jpg",Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(File));
            StartActivityForResult(intent,0);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Make it available in the gallery

            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(File);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

            // Display in ImageView. We will resize the bitmap to fit the display.
            // Loading the full sized image will consume to much memory
            // and cause the application to crash.

            int height = Resources.DisplayMetrics.HeightPixels;
            int width = ImageView.Height;
            Bitmap = File.Path.LoadAndResizeBitmap(width, height);
            if (Bitmap != null)
            {
                ImageView.SetImageBitmap(Bitmap);
                Bitmap= null;
            }

            // Dispose of the Java side bitmap.
            GC.Collect();
        }

        public override void OnBackPressed()
        {

        }
    }

    public static class BitmapHelpers
    {
        public static Bitmap LoadAndResizeBitmap(this string fileName, int width, int height)
        {
            // First we get the the dimensions of the file on disk
            BitmapFactory.Options options = new BitmapFactory.Options { InJustDecodeBounds = true };
            BitmapFactory.DecodeFile(fileName, options);

            // Next we calculate the ratio that we need to resize the image by
            // in order to fit the requested dimensions.
            int outHeight = options.OutHeight;
            int outWidth = options.OutWidth;
            int inSampleSize = 1;

            if (outHeight > height || outWidth > width)
            {
                inSampleSize = outWidth > outHeight
                                   ? outHeight / height
                                   : outWidth / width;
            }

            // Now we will load the image and have BitmapFactory resize it for us.
            options.InSampleSize = inSampleSize;
            options.InJustDecodeBounds = false;
            Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

            return resizedBitmap;
        }
    }
}