using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.Android;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CustomControls.Controls;
using CustomControls.Droid.Renderers;

[assembly: ExportRenderer(typeof(ShadedButton), typeof(ShadedButtonRenderer))]
namespace CustomControls.Droid.Renderers
{
    public class ShadedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                Control.SetBackgroundColor(Android.Graphics.Color.Gray);
        }
    }
}