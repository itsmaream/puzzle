using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace puzzle

{

    public class Splashpage : ContentPage
    {
        Image SplashImage;
        public Splashpage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "image.png",
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);
            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await SplashImage.ScaleTo(1, 2000);
            await SplashImage.ScaleTo(0.9, 1500, Easing.BounceOut);
            await SplashImage.ScaleTo(500, 1200, Easing.BounceOut);
            await Application.Current.MainPage.Navigation.PushModalAsync(new Page0());
        }
    }
}
