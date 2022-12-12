using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalorikalkulaator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeightPage : ContentPage
    {
        public object Text;

        public WeightPage()
        {
            InitializeComponent();
        }
        private void BtnSub1_Clicked(object sender, EventArgs e)
        {
            double a = Double.Parse(num9.Text);
            double b = Double.Parse(num8.Text);
            res1.Text = (a / (b*b)).ToString();
        }
        
        private void BtnSub3_Clicked(object sender, EventArgs e)
        {
          
            double f = Double.Parse(num11.Text);
            double g = Double.Parse(num12.Text);
            double k = Double.Parse(num7.Text);



            res2.Text = (10*f+(6.25*g)-(5*k)+5).ToString();
        }
        private void BtnClr3_Clicked(object sender, EventArgs e)
        {
            
            double w = Double.Parse(num11.Text);
            double y = Double.Parse(num12.Text);
          
            double r = Double.Parse(num7.Text);
            res3.Text = (10 * w + (6.25 * y) - (5 * r) -161).ToString();
        }
        private void BtnClr2_Clicked(object sender, EventArgs e)
        {
            num9.Text = String.Empty;
            num8.Text = String.Empty;
            num7.Text = String.Empty;
            num11.Text = String.Empty;
            num12.Text = String.Empty;
            res1.Text = String.Empty;
            res2.Text = String.Empty;
            res3.Text = String.Empty;

        }
    }

    internal class num7
    {
        public static string Text { get; internal set; }
    }

    internal class res2
    {
        internal static string Text;
    }

    internal class res3
    {
        internal static string Text;
    }
    internal class res1
    {
        internal static string Text;
    }
}