using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NestedScrollTest.CustomRenderer.NestedScroll), 
    typeof(NestedScrollTest.Droid.CustomRendererDroid.NestedScrollDroid))]
namespace NestedScrollTest.Droid.CustomRendererDroid
{
    public class NestedScrollDroid: ListViewRenderer
    {
        public NestedScrollDroid(Android.Content.Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                var listview = this.Control as Android.Widget.ListView;
                listview.NestedScrollingEnabled = true;
            }
        }
    }
}