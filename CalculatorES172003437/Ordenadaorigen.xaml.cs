using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorES172003437
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ordenadaorigen : ContentPage
    {
        public Ordenadaorigen()
        {
            InitializeComponent();
        }
        async void volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        public void Button_Clicked(object sender, EventArgs e)
        {
            double op1, op2;
            var y1 = double.Parse(y.Text);
            var x1 = double.Parse(x.Text);
            var b1 = double.Parse(b.Text);
            op1 = (x1 / y1);
            op2 = (b1 / y1);
            var res = op1;
            resultado.Text = res.ToString();

        }
    }
}