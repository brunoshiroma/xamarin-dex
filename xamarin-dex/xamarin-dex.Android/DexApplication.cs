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
using xamarin_dex.Views.Views;
using static Android.App.Application;

namespace xamarin_dex.Droid
{
    [Application]
    class DexApplication : Android.App.Application, IActivityLifecycleCallbacks
    {

        static Activity _current;

        public DexApplication(IntPtr a, JniHandleOwnership b) : base(a, b)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
        }

        public void OnActivityDestroyed(Activity activity)
        {
        }

        public void OnActivityPaused(Activity activity)
        {
        }

        public void OnActivityResumed(Activity activity)
        {
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
        }

        public void OnActivityStarted(Activity activity)
        {
            _current = activity;

            Color statusBarColor = (Color)Xamarin.Forms.Application.Current.Resources["Primary"];

            DependencyService
                .Get<IStatusBarPlatformSpecific>()
                .SetStatusBarColor(statusBarColor);
        }

        public void OnActivityStopped(Activity activity)
        {
            _current = null;
        }

        public static Activity CurrentActivity { get 
            {
                return _current;
            } }
    }
}