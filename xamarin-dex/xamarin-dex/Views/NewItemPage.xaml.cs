using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using xamarin_dex.Models;
using xamarin_dex.ViewModels;

namespace xamarin_dex.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Pokemon Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}