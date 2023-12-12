/*using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using dafka__;
using dafka__.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomRender))]
namespace dafka__.Droid
{
    
    public class CustomRender : EntryRenderer
    {
        public CustomRender(Context context) : base(context)
        {
        }
       CustomEntry customEntry;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(customEntry.EntryCornerRadius);
                gradientDrawable.SetStroke(2, customEntry.BorderColor.ToAndroid());
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}*/



