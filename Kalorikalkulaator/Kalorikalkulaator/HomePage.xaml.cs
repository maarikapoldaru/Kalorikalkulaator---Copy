using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Provider.ContactsContract.Contacts;
using SQLite;
using Xamarin.Forms;

namespace Kalorikalkulaator
{
    public partial class HomePage : ContentPage
    {
        
        
        public HomePage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

             
            var toitList = await App.SQLiteDb.GetItemsAsync();
            if (toitList != null)
            {
                lstToidud.ItemsSource = toitList;
            }
        }
        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Toit toit = new Toit()
                {
                    
                    ToitID= Convert.ToInt32(txtToitId.Text),
                    Spec = txtSpec.Text,
                    Name = txtName.Text,
                    Num = txtNum.Text
                };

                
                await App.SQLiteDb.SaveItemAsync(toit);
                txtToitId.Text = string.Empty;
                txtSpec.Text = string.Empty;
                txtName.Text = string.Empty;
                txtNum.Text = string.Empty;
                    await DisplayAlert("Success", "Data added Successfully", "OK");
                
                var toitList = await App.SQLiteDb.GetItemsAsync();
                if (toitList != null)
                {
                    lstToidud.ItemsSource = toitList;
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter data!", "OK");
            }
        }

        private async void BtnRead_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToitId.Text))
            {
                
                var toit = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtToitId.Text));
                if (toit != null)
                {
                    txtToitId.Text = Convert.ToString(toit.ToitID);
                    
                    await DisplayAlert("Success", "ToitId:" + toit.ToitID, "OK");
                    txtSpec.Text = toit.Spec;
                    await DisplayAlert("Success", "Date:" + toit.Spec, "OK");
                    txtName.Text = toit.Name;
                    await DisplayAlert("Success", "Name: " + toit.Name, "OK");
                    txtNum.Text = toit.Num;
                    await DisplayAlert("Success", "Num: " + toit.Num, "OK");
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter Data", "OK");
            }
        }

        private Task DisplayAlert(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            throw new NotImplementedException();
        }

        private Task DisplayAlert(string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToitId.Text))
            {
                Toit toit = new Toit()
                {
                    ToitID = Int32.Parse(txtToitId.Text),
                    Spec= txtSpec.Text,
                    Name = txtName.Text,
                    Num = txtNum.Text
                };

                 
                await App.SQLiteDb.SaveItemAsync(toit);

                txtToitId.Text = string.Empty;
                txtSpec.Text = string.Empty;
                txtName.Text = string.Empty;
                txtNum.Text = string.Empty;
                await DisplayAlert("Success", " Updated Successfully", "OK");
                 
                var toitList = await App.SQLiteDb.GetItemsAsync();
                if (toitList != null)
                {
                    lstToidud.ItemsSource = toitList;
                }

            }
            else
            {
                await DisplayAlert("Required", "Please Enter Data", "OK");
            }
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToitId.Text))
            {
                 
                var toit = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtToitId.Text));
                if (toit != null)
                {
                      
                    await App.SQLiteDb.DeleteItemAsync(toit);
                    txtToitId.Text = string.Empty;
                    txtSpec.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtNum.Text = string.Empty;
                    await DisplayAlert("Success", "Data Deleted", "OK");

                     
                    var toitList = await App.SQLiteDb.GetItemsAsync();
                    if (toitList != null)
                    {
                        lstToidud.ItemsSource = toitList;
                    }
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter Data", "OK");
            }
        }
    }

    internal class txtSpec
    {
        public static string Text { get; internal set; }
    }

    internal class txtToitId
    {
        public static string Text { get; internal set; }
    }
}    
            