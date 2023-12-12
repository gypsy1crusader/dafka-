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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        private async void End(object sender, EventArgs e)
        {
            
            if(KochI.IsChecked || SokolD.IsChecked || SotnikA.IsChecked)
            {
                await Navigation.PushAsync(new Page4());
            }
            else
            {
                errorMessage.Text = "Выберите мастера";
            }
           
        }
    }
}