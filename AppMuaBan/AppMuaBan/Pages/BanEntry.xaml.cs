using System;
using System.IO;
using Xamarin.Forms;
using AppMuaBan.Models;

namespace AppMuaBan
{
    public partial class BanEntry : ContentPage
    {
        public BanEntry()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var sp = (Sanpham)BindingContext;
            await App.Database.SaveSanphamAsync(sp);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var sp = (Sanpham)BindingContext;
            await App.Database.DeleteSanphamAsync(sp);
            await Navigation.PopAsync();
        }
    }
}