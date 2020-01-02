using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMuaBan.Models;
using Xamarin.Forms;
using AppMuaBan.Pages;
using Xamarin.Forms.Xaml;

namespace AppMuaBan
{
    public partial class CTDH : ContentPage
    {
        public CTDH()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var don_hang = (Donhang)BindingContext;
            await App.Database.DeleteDonhangAsync(don_hang);
            await Navigation.PopAsync();
        }
    }
}