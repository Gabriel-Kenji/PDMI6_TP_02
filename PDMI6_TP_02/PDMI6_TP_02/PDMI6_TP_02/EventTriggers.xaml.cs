using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMI6_TP_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventTriggers : ContentPage
    {
        public EventTriggers()
        {
            InitializeComponent();
        }

        async void Voltar(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}