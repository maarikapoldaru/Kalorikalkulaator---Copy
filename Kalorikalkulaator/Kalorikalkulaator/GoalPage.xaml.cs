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
    public partial class GoalPage
    {
        private object result;
       


        public GoalPage()
        {
            InitializeComponent();
        }
        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
           
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            double c = Double.Parse(num3.Text);
            double d = Double.Parse(num4.Text);
            res.Text = (a + b + c + d).ToString();
        }
        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            double f = Double.Parse(num5.Text);
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            double c = Double.Parse(num3.Text);
            double d = Double.Parse(num4.Text);
            res.Text = (f-d-a-b-c).ToString();
            
        }
        
       
        
        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            num3.Text = String.Empty;
            num4.Text = String.Empty;
            num5.Text = String.Empty;
            res.Text = String.Empty;
        }
    }
}