using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using DocumentFormat.OpenXml.Bibliography;
//using Android.Widget;
using Xamarin.Forms.Xaml;

namespace Kalorikalkulaator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class NotePage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.txt");

        private string text;


        string Text;

        public NotePage()
        {
            InitializeComponent();


            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);

            }

        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);

        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {


            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;

        }




    }


}











