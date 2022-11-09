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
    public partial class punto : ContentPage
    {
        public punto()
        {
            InitializeComponent();
        }
        async void regreso(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public void Button_Clicked1(object sender, EventArgs e)
        {

            double op1,op2,op4;
            var X1 = double.Parse(x1.Text);
            var Y1 = double.Parse(y1.Text);
            var M = double.Parse(m.Text);
            var r = op1 =  (1)-(Y1);
            var d = op2 = (M)*(-X1);
            var en = (-op1) + (op2);
            var f = op4 =  M;
            opc1.Text = r.ToString();
            opc2.Text = d.ToString();
            opc4.Text = f.ToString();
            opc3.Text = en.ToString();



            DisplayAlert("El resultado es ","","OK");
            
        }

    }
}