using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dafka__
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class register : ContentPage
    {
        public register()
        {
            InitializeComponent();
           


        }
        private async void Reg(object sender, EventArgs e)
        {
            
            if (name.Text == null || surname.Text == null || mail.Text == null || tele.Text == null)
            {
                errorMessages.Text = "Заполните все данные";
            }
            else
            {
                var naming = name.Text;
                var surnaming = surname.Text;
                var email = mail.Text;
                var telephone = tele.Text;


                errorMessages.Text = "";
               await Navigation.PushAsync(new Page1());
            }
        }
    }
}