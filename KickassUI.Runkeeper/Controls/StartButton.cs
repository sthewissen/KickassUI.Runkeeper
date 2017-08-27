using System;
using Xamarin.Forms;

namespace KickassUI.Runkeeper.Controls
{
    public class StartButton : Button
    {
        public static readonly BindableProperty LabelProperty = BindableProperty.Create(
            propertyName: nameof(Label),
            returnType: typeof(string),
            declaringType: typeof(StartButton),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay
        );

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly BindableProperty LabelColorProperty = BindableProperty.Create(
           propertyName: nameof(LabelColor),
           returnType: typeof(Color),
           declaringType: typeof(StartButton),
           defaultValue: Color.Black,
           defaultBindingMode: BindingMode.TwoWay
       );

        public Color LabelColor
        {
            get { return (Color)GetValue(LabelColorProperty); }
            set { SetValue(LabelColorProperty, value); }
        }

        public static readonly BindableProperty LabelFontSizeProperty = BindableProperty.Create(
           propertyName: nameof(LabelFontSize),
           returnType: typeof(double),
           declaringType: typeof(StartButton),
           defaultValue: 14.0,
           defaultBindingMode: BindingMode.TwoWay
       );

        public double LabelFontSize
        {
            get { return (double)GetValue(LabelFontSizeProperty); }
            set { SetValue(LabelFontSizeProperty, value); }
        }
    }
}
