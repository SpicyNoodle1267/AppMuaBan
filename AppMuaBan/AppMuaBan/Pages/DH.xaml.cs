using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMuaBan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMuaBan.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DH : ContentPage
    {
        public DH()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetDonhangAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CTDH()
                {
                    BindingContext = e.SelectedItem as Donhang
                });
            }
        }
    }
}