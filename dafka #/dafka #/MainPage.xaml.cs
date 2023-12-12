using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dafka__
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            string urImage = "https://i.imgur.com/JPKa7Fv.png";
            myImage.Source = new UriImageSource
            {
                Uri = new Uri(urImage),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(3, 0, 0, 0)
            };
            myImage.Aspect = Aspect.AspectFill;
            
        }
        private async void Button1Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new register());
        }
    }
}
   
