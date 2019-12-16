using System;
using System.ComponentModel;
using Android.Content;
using Android.Gms.Ads;
using Android.Widget;
using puzzle.Controls;
using puzzle.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdMobViewRenderer))]

namespace puzzle.Droid.Renderers
{
    public class AdMobViewRenderer : ViewRenderer<AdControlView, AdView>
    {
        public AdMobViewRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control == null)
                SetNativeControl(CreateAdView());
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == nameof(AdView.AdUnitId))
                Control.AdUnitId = Element.AdUnitId;
        }

        private AdView CreateAdView()
        {
            var adView = new AdView(Context)
            {
                AdSize = AdSize.Banner,
                AdUnitId = Element.AdUnitId
            };

            adView.LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);

            //.AddTestDevice("E34A6FDD4CD7ACBF303BA5C596710C24")
            adView.LoadAd(new AdRequest.Builder().Build());

            return adView;
        }
    }
}
