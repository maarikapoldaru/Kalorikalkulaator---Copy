using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kalorikalkulaator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
         private void Button1_Clicked(object sender, EventArgs e)
         {
             Navigation.PushAsync(new WeightPage());
         }
         private void Button2_Clicked(object sender, EventArgs e)
         {
             Navigation.PushAsync(new CaloriePage());
         }
         private void Button3_Clicked(object sender, EventArgs e)
         {
             Navigation.PushAsync(new GoalPage());
         }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new HomePage());
        }
        private void Button5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotePage());
        }
    }
}

