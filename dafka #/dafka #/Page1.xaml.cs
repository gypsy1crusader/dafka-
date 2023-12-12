using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dafka__
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        public Page1()
        {
            InitializeComponent();
          
        }
       
        private async void Choose(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void Haircut(object sender, EventArgs e)
        {
            count1++;
            Button cut = (Button)sender;
            if (count1 % 2 == 0 || count1 == 1)
            {
                cut.Text = "Выбрано";
            }
            else 
            {
                cut.Text = "Стрижка";
            }


        }
        private async void Beard(object sender, EventArgs e)
        {
            count2++;
            Button beard = (Button)sender;
            if (count2 % 2 == 0 || count2 == 1)
            {
                beard.Text = "Выбрано";
            }
            else
            {
                beard.Text = "Уход за бородой";
            }
            
        }
        private async void Color(object sender, EventArgs e)
        {
            count3++;
            Button color = (Button)sender;
            if (count3 % 2 == 0 || count3 == 1)
            {
                color.Text = "Выбрано";
            }
            else
            {
                color.Text = "Окрашивание";
            }


        }
    }
}