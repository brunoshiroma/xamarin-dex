using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace xamarin_dex.Views.Views
{
    public interface IStatusBarPlatformSpecific
    {
        void SetStatusBarColor(Color color);
    }
}
