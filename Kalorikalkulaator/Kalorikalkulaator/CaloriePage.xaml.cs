using Kalorikalkulaator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Text;



namespace Kalorikalkulaator
{
    public partial class CaloriePage : ContentPage
    {
        public List<Nutrients> tempdata;
        public CaloriePage()
        {
            InitializeComponent();
            data();
            list.ItemsSource = tempdata;
        }
        private void Calc_Clicked(object sender, EventArgs e)
        {
            double a = Double.Parse(number1.Text);
            double b = Double.Parse(number2.Text);
            res9.Text = (a * b).ToString();
        }

        public void data()
        {
            // all the temp data  
            tempdata = new List<Nutrients> {
                new Nutrients(){ Name = "nisujahu", Num = "348"},
                new Nutrients(){ Name = "riis", Num = "371"},
                new Nutrients(){ Name = "pastatooted", Num = "344"},
                new Nutrients(){ Name = "pudruhelbed", Num = "382"},
                new Nutrients(){ Name = "hommikusöögihelbed", Num = "373"},
                new Nutrients(){ Name = "leib", Num = "211"},
                new Nutrients(){ Name = "sepik", Num = "232"},
                new Nutrients(){ Name = "sai", Num = "275"},
                new Nutrients(){ Name = "kartul", Num = "115"},
                new Nutrients(){ Name = "seened", Num = "47"},
                new Nutrients(){ Name = "viliköögiviljad", Num = "21"},
                new Nutrients(){ Name = "sibulköögiviljad", Num = "27"},
                new Nutrients(){ Name = "lehtköögiviljad", Num = "15"},
                new Nutrients(){ Name = "kapsad", Num = "34"},
                new Nutrients(){ Name = "juurviljad", Num = "49"},
                new Nutrients(){ Name = "kaunviljad", Num = "33"},
                new Nutrients(){ Name = "tsitrusviljad", Num = "42"},
                new Nutrients(){ Name = "luuviljad", Num = "37"},
                new Nutrients(){ Name = "õun, pirn", Num = "54"},
                new Nutrients(){ Name = "trooplised viljad", Num = "46"},
                new Nutrients(){ Name = "marjad", Num = "52"},
                new Nutrients(){ Name = "puuviljamahl", Num = "55"},
                new Nutrients(){ Name = "piim", Num = "52"},
                new Nutrients(){ Name = "jogurt", Num = "141"},
                new Nutrients(){ Name = "hapukoor", Num = "118"},
                new Nutrients(){ Name = "kohupiim", Num = "97"},
                new Nutrients(){ Name = "juust", Num = "218"},
                 new Nutrients(){ Name = "sealiha", Num = "221"},
                new Nutrients(){ Name = "veiseliha", Num = "184"},
                new Nutrients(){ Name = "viiner", Num = "193"},
                new Nutrients(){ Name = "kanaliha", Num = "207"},
                 new Nutrients(){ Name = "kala", Num = "84"},
                new Nutrients(){ Name = "muna", Num = "179"},
                new Nutrients(){ Name = "viiner", Num = "193"},
                new Nutrients(){ Name = "kanaliha", Num = "207"},
            };
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                list.ItemsSource = tempdata;
            }

            else
            {
                list.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
               
            }
        }
        
    }

    internal class list
    {
        public static List<Nutrients> ItemsSource { get; internal set; }
    }
}

    
       
          

       

 

       
    
    
