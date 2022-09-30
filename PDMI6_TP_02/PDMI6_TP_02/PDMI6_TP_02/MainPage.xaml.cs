using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDMI6_TP_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void EstiloPadrao(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new EstiloPadrao());
        }
        private async void EstiloDinamico(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EstiloDinamico());
        }
        private async void EventTriggers(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EventTriggers());
        }

        private async void ViewSimples(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ViewSimples());
        }

        private async void Home(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Home());
        }

        private async void Produto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PgProduto());
        }
    } 
}
