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
    public partial class Mua : ContentPage
    {
        public Mua()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetSanphamAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new MuaEntry()
            {
                BindingContext = e.SelectedItem as Sanpham
            });
        }
    }
}