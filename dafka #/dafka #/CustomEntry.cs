using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace dafka__
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty CornerRadProp = BindableProperty.Create("CornerRadius", typeof(int), typeof(CustomEntry), 0);

        public int EntryCornerRadius
        {
            get { return  (int)GetValue(CornerRadProp); }
            set { SetValue(CornerRadProp, value);}
        }

    public static readonly BindableProperty BorderColorProp = BindableProperty.Create("BorderThickness", typeof(Color), typeof(CustomEntry), Color.Black);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProp); }
            set { SetValue(BorderColorProp, value); }
        }
        public static readonly BindableProperty BorderThickness = BindableProperty.Create("BorderThickness", typeof(int), typeof(CustomEntry), 0);
        public int EntryBorderThickness
        {
            get { return (int)GetValue(BorderThickness); }
            set { SetValue(BorderThickness, value); }
        }
    }
}
