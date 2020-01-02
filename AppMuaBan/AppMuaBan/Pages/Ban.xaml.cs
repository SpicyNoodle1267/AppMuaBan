using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using AppMuaBan.Models;

namespace AppMuaBan.Pages
{
    public partial class Ban : ContentPage
    {
        public Ban()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetSanphamAsync();
        }
        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanEntry()
            {
                BindingContext = new Sanpham()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BanEntry()
                {
                    BindingContext = e.SelectedItem as Sanpham
                });
            }
        }
    }
}