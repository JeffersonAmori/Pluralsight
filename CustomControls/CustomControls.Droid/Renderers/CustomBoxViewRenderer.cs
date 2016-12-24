using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using CustomControls.Controls;
using System.ComponentModel;
using Xamarin.Forms;
using CustomControls.Droid.Renderers;

[assembly:ExportRenderer(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace CustomControls.Droid.Renderers
{
    class CustomBoxViewRenderer : BoxRenderer
    {
        public CustomBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            CustomBoxView boxView = (CustomBoxView)Element;

            Rect rectancle = new Rect();
            GetDrawingRect(rectancle);

            Rect inside = new Rect();
            inside.Inset(
                (int)boxView.BorderThickness, 
                (int)boxView.BorderThickness);

            Paint p = new Paint();
            p.Color = boxView.Color.ToAndroid();

            canvas.DrawRect(inside, p);

            p.Color = boxView.BorderColor.ToAndroid();
            p.StrokeWidth = (float)boxView.BorderThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRect(rectancle, p);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            Invalidate();
        }
    }
}