using System;
using System.Collections.Generic;
using Xamarin.Forms;
using xamarin_dex.ViewModels;
using xamarin_dex.Views;

namespace xamarin_dex
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
