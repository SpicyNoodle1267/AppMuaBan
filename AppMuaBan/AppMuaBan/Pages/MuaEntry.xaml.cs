using System;
using System.IO;
using Xamarin.Forms;
using AppMuaBan.Models;

namespace AppMuaBan
{
    public partial class MuaEntry : ContentPage
    {
        public MuaEntry()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var d = (Sanpham)BindingContext;
            Donhang DH = new Donhang { TenSP = d.TenSP, SL = int.Parse(soluong.Text), SDT = sodt.Text, Address = diachi.Text, date = DateTime.UtcNow};
            await App.Database.SaveDonhangAsync(DH);
            await Navigation.PopAsync();
        }
        async void OnCancelButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}