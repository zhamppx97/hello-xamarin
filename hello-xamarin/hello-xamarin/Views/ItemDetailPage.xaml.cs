using System.ComponentModel;
using Xamarin.Forms;
using hello_xamarin.ViewModels;

namespace hello_xamarin.Views
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