using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMuaBan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Mua_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Mua());
        }

        async void Button_Ban_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Ban());
        }

        async void Button_Donhang_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.DH());
        }
    }
}
