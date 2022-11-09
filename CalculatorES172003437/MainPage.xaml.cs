using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorES172003437
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void ir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ordenadaorigen { });
        }
        async void partir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new punto { });
        }
        public void terminar(object sender, EventArgs e)
        {
           
        }
    }
}
