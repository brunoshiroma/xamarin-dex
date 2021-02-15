using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace xamarin_dex.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            //UIView statusBar = UIApplication.SharedApplication.ValueForKey(
            //new NSString("statusBar")) as UIView;

            //Object outColor;
            //Color statusBarColor;

            ////if(Xamarin.Forms.Application.Current.Resources.TryGetValue("Primary", out outColor))
            ////{
            ////    statusBarColor = (Color)outColor;
            ////}
            ////else
            ////{
            //    statusBarColor = Color.Red;
            ////}


            //if (statusBar != null && statusBar.RespondsToSelector(
            //new ObjCRuntime.Selector("setBackgroundColor:")))
            //{
            //    statusBar.BackgroundColor = statusBarColor.ToUIColor();
            //}
        }
    }
}
