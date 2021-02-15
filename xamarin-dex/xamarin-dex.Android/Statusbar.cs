using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using xamarin_dex.Droid;
using xamarin_dex.Views.Views;

[assembly: Dependency(typeof(Statusbar))]
namespace xamarin_dex.Droid
{    
    class Statusbar : IStatusBarPlatformSpecific
    {
        public void SetStatusBarColor(Color color)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                var androidColor = color.AddLuminosity(-0.1).ToAndroid();
                //Use the plugin
                DexApplication.CurrentActivity.Window.SetStatusBarColor(androidColor);
            }
            else
            {
                // Here you will just have to set your color in styles.xml file as above.
            }
        }
    }
}