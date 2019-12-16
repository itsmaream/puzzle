using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace puzzle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page0 : ContentPage
    {
        public Page0()
        {
            InitializeComponent();
        }

        public void Audio1()
        {
            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current; ;

            sound.Load("button_click.mp3");

            sound.Play();
        }

        private async void Bu1_Clicked(object sender, EventArgs e)
        {
            Audio1();
            await Application.Current.MainPage.Navigation.PopModalAsync();
            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
        }

        private async void Bu2_Clicked(object sender, EventArgs e)
        {
            Audio1();
            await Application.Current.MainPage.Navigation.PopModalAsync();
            await Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
        }
    }
}