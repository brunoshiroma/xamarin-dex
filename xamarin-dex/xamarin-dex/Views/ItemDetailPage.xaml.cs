using System.ComponentModel;
using Xamarin.Forms;
using xamarin_dex.ViewModels;

namespace xamarin_dex.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}