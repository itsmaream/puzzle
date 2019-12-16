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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void Audio()
        {
            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current; ;

            sound.Load("SoundBible.mp3");

            sound.Play();
        }

        public void Audio1()
        {
            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current; ;

            sound.Load("button_click.mp3");

            sound.Play();
        }
        public Color co = new Color();
        private void Bu8_Clicked(object sender, EventArgs e)
        {
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu8.Text;
                bu8.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu8.Text;
                bu8.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu8.Text;
                bu8.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu7.Text;
                bu7.Text = bu8.Text;
                bu8.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu12.Text;
                bu12.Text = bu8.Text;
                bu8.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu6.Text;
                bu6.Text = bu7.Text;
                bu7.Text = bu8.Text;
                bu8.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu1_Clicked(object sender, EventArgs e)
        {
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu1.Text;
                bu1.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu1.Text;
                bu1.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu2.Text;
                bu2.Text = bu1.Text;
                bu1.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu5.Text;
                bu5.Text = bu1.Text;
                bu1.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu3.Text;
                bu3.Text = bu2.Text;
                bu2.Text = bu1.Text;
                bu1.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            if (bu13.Text == "")
            {
                Audio();
                bu13.Text = bu9.Text;
                bu9.Text = bu5.Text;
                bu5.Text = bu1.Text;
                bu1.Text = "";

                co = bu13.BackgroundColor;
                bu13.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu12_Clicked(object sender, EventArgs e)
        {
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu12.Text;
                bu12.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu12.Text;
                bu12.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu12.Text;
                bu12.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu8.Text;
                bu8.Text = bu12.Text;
                bu12.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu11.Text;
                bu11.Text = bu12.Text;
                bu12.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu10.Text;
                bu10.Text = bu11.Text;
                bu11.Text = bu12.Text;
                bu12.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu16_Clicked(object sender, EventArgs e)
        {
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu16.Text;
                bu16.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu16.Text;
                bu16.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu12.Text;
                bu12.Text = bu16.Text;
                bu16.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu15.Text;
                bu15.Text = bu16.Text;
                bu16.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu8.Text;
                bu8.Text = bu12.Text;
                bu12.Text = bu16.Text;
                bu16.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            if (bu13.Text == "")
            {
                Audio();
                bu13.Text = bu14.Text;
                bu14.Text = bu15.Text;
                bu15.Text = bu16.Text;
                bu16.Text = "";

                co = bu14.BackgroundColor;
                bu13.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = bu16.BackgroundColor;
                bu16.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu2_Clicked(object sender, EventArgs e)
        {

            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu2.Text;
                bu2.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu2.Text;
                bu2.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu2.Text;
                bu2.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu3.Text;
                bu3.Text = bu2.Text;
                bu2.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu6.Text;
                bu6.Text = bu2.Text;
                bu2.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu10.Text;
                bu10.Text = bu6.Text;
                bu6.Text = bu2.Text;
                bu2.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu6_Clicked(object sender, EventArgs e)
        {

            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu6.Text;
                bu6.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu6.Text;
                bu6.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu6.Text;
                bu6.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu6.Text;
                bu6.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu7.Text;
                bu7.Text = bu6.Text;
                bu6.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu10.Text;
                bu10.Text = bu6.Text;
                bu6.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu3_Clicked(object sender, EventArgs e)
        {
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu3.Text;
                bu3.Text = "";

                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu3.Text;
                bu3.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu3.Text;
                bu3.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu2.Text;
                bu2.Text = bu3.Text;
                bu3.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu7.Text;
                bu7.Text = bu3.Text;
                bu3.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu11.Text;
                bu11.Text = bu7.Text;
                bu7.Text = bu3.Text;
                bu3.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu4_Clicked(object sender, EventArgs e)
        {
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu4.Text;
                bu4.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu4.Text;
                bu4.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu3.Text;
                bu3.Text = bu4.Text;
                bu4.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu8.Text;
                bu8.Text = bu4.Text;
                bu4.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu2.Text;
                bu2.Text = bu3.Text;
                bu3.Text = bu4.Text;
                bu4.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu12.Text;
                bu12.Text = bu8.Text;
                bu8.Text = bu4.Text;
                bu4.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu12.BackgroundColor;
                bu12.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu5_Clicked(object sender, EventArgs e)
        {
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu5.Text;
                bu5.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu5.Text;
                bu5.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu5.Text;
                bu5.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu6.Text;
                bu6.Text = bu5.Text;
                bu5.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu13.Text == "")
            {
                bu13.Text = bu9.Text;
                bu9.Text = bu5.Text;
                bu5.Text = "";

                co = bu13.BackgroundColor;
                bu13.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu7.Text;
                bu7.Text = bu6.Text;
                bu6.Text = bu5.Text;
                bu5.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu7_Clicked(object sender, EventArgs e)
        {
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu7.Text;
                bu7.Text = "";

                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu7.Text;
                bu7.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu7.Text;
                bu7.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu7.Text;
                bu7.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu11.Text;
                bu11.Text = bu7.Text;
                bu7.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu6.Text;
                bu6.Text = bu7.Text;
                bu7.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu9_Clicked(object sender, EventArgs e)
        {
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu9.Text;
                bu9.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu9.Text;
                bu9.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu13.Text == "")
            {
                Audio();
                bu13.Text = bu9.Text;
                bu9.Text = "";

                co = bu13.BackgroundColor;
                bu13.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu10.Text;
                bu10.Text = bu9.Text;
                bu9.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu5.Text;
                bu5.Text = bu9.Text;
                bu9.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu11.Text;
                bu11.Text = bu10.Text;
                bu10.Text = bu9.Text;
                bu9.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu10_Clicked(object sender, EventArgs e)
        {
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu10.Text;
                bu10.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu10.Text;
                bu10.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu10.Text;
                bu10.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu6.Text;
                bu6.Text = bu10.Text;
                bu10.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu10.Text;
                bu10.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu11.Text;
                bu11.Text = bu10.Text;
                bu10.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu11_Clicked(object sender, EventArgs e)
        {
            if (bu12.Text == "")
            {
                Audio();
                bu12.Text = bu11.Text;
                bu11.Text = "";

                co = bu12.BackgroundColor;
                bu12.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu11.Text;
                bu11.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu11.Text;
                bu11.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu11.Text;
                bu11.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu7.Text;
                bu7.Text = bu11.Text;
                bu11.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu10.Text;
                bu10.Text = bu11.Text;
                bu11.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu13_Clicked(object sender, EventArgs e)
        {
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu13.Text;
                bu13.Text = "";

                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu13.Text;
                bu13.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu9.Text;
                bu9.Text = bu13.Text;
                bu13.Text = "";

                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu14.Text;
                bu14.Text = bu13.Text;
                bu13.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu5.Text;
                bu5.Text = bu9.Text;
                bu9.Text = bu13.Text;
                bu13.Text = "";

                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu15.Text;
                bu15.Text = bu14.Text;
                bu14.Text = bu13.Text;
                bu13.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = bu13.BackgroundColor;
                bu13.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu14_Clicked(object sender, EventArgs e)
        {
            if (bu13.Text == "")
            {
                Audio();
                bu13.Text = bu14.Text;
                bu14.Text = "";

                co = bu13.BackgroundColor;
                bu13.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            if (bu10.Text == "")
            {
                Audio();
                bu10.Text = bu14.Text;
                bu14.Text = "";

                co = bu10.BackgroundColor;
                bu10.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            if (bu15.Text == "")
            {
                Audio();
                bu15.Text = bu14.Text;
                bu14.Text = "";

                co = bu15.BackgroundColor;
                bu15.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu15.Text;
                bu15.Text = bu14.Text;
                bu14.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu10.Text;
                bu10.Text = bu14.Text;
                bu14.Text = "";

                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu6.Text;
                bu6.Text = bu10.Text;
                bu10.Text = bu14.Text;
                bu14.Text = "";

                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu10.BackgroundColor;
                bu10.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = co;
            }
            Winer();
        }
        private void Bu15_Clicked(object sender, EventArgs e)
        {

            if (bu11.Text == "")
            {
                Audio();
                bu11.Text = bu15.Text;
                bu15.Text = "";

                co = bu11.BackgroundColor;
                bu11.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            if (bu14.Text == "")
            {
                Audio();
                bu14.Text = bu15.Text;
                bu15.Text = "";

                co = bu14.BackgroundColor;
                bu14.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            if (bu16.Text == "")
            {
                Audio();
                bu16.Text = bu15.Text;
                bu15.Text = "";

                co = bu16.BackgroundColor;
                bu16.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            if (bu13.Text == "")
            {
                Audio();
                bu13.Text = bu14.Text;
                bu14.Text = bu15.Text;
                bu15.Text = "";

                co = bu13.BackgroundColor;
                bu13.BackgroundColor = bu14.BackgroundColor;
                bu14.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu11.Text;
                bu11.Text = bu15.Text;
                bu15.Text = "";

                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu7.Text;
                bu7.Text = bu11.Text;
                bu11.Text = bu15.Text;
                bu15.Text = "";

                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = bu11.BackgroundColor;
                bu11.BackgroundColor = bu15.BackgroundColor;
                bu15.BackgroundColor = co;
            }
            Winer();
        }
        public void Winer()
        {
            if (bu1.Text == "1" && bu2.Text == "2" && bu3.Text == "3" && bu4.Text == "4" && bu5.Text == "5" && bu6.Text == "6" &&
                bu7.Text == "7" && bu8.Text == "8" && bu9.Text == "9" && bu10.Text == "10" && bu11.Text == "11" && bu12.Text == "12" &&
                bu13.Text == "13" && bu14.Text == "14" && bu15.Text == "15" && bu16.Text == "")
            {
                bu16.Text = "16";
                Le.Text = "winer 😃";
            }
        }

        private void Bu_Clicked(object sender, EventArgs e)
        {
            Audio1();
            Le.Text = "play";
            Rand();
        }

        public string rand = "2";
        public void Rand()
        {
            Random r = new Random();
            rand = r.Next(1, 4).ToString();

            if(rand=="1")
            {
                bu1.Text = "15";
                bu2.Text = "10";
                bu3.Text = "12";
                bu4.Text = "7";
                bu5.Text = "5";
                bu6.Text = "6";
                bu7.Text = "14";
                bu8.Text = "13";
                bu9.Text = "1";
                bu10.Text = "3";
                bu11.Text = "4";
                bu12.Text = "2";
                bu13.Text = "8";
                bu14.Text = "9";
                bu15.Text = "11";
                bu16.Text = "";
                bu1.BackgroundColor = Color.Blue;
                bu2.BackgroundColor = Color.Blue;
                bu3.BackgroundColor = Color.Blue;
                bu4.BackgroundColor = Color.Blue;
                bu5.BackgroundColor = Color.Blue;
                bu6.BackgroundColor = Color.Red;
                bu7.BackgroundColor = Color.Red;
                bu8.BackgroundColor = Color.Blue;
                bu9.BackgroundColor = Color.Red;
                bu10.BackgroundColor = Color.Red;
                bu11.BackgroundColor = Color.Blue;
                bu12.BackgroundColor = Color.Blue;
                bu13.BackgroundColor = Color.Red;
                bu14.BackgroundColor = Color.Red;
                bu15.BackgroundColor = Color.Red;
                bu16.BackgroundColor = Color.Red;
            }

            if (rand == "2")
            {
                bu1.Text = "8";
                bu2.Text = "5";
                bu3.Text = "15";
                bu4.Text = "10";
                bu5.Text = "9";
                bu6.Text = "1";
                bu7.Text = "6";
                bu8.Text = "7";
                bu9.Text = "4";
                bu10.Text = "3";
                bu11.Text = "2";
                bu12.Text = "13";
                bu13.Text = "14";
                bu14.Text = "12";
                bu15.Text = "11";
                bu16.Text = "";
                bu1.BackgroundColor = Color.Red;
                bu2.BackgroundColor = Color.Blue;
                bu3.BackgroundColor = Color.Blue;
                bu4.BackgroundColor = Color.Blue;
                bu5.BackgroundColor = Color.Red;
                bu6.BackgroundColor = Color.Red;
                bu7.BackgroundColor = Color.Red;
                bu8.BackgroundColor = Color.Blue;
                bu9.BackgroundColor = Color.Blue;
                bu10.BackgroundColor = Color.Red;
                bu11.BackgroundColor = Color.Blue;
                bu12.BackgroundColor = Color.Blue;
                bu13.BackgroundColor = Color.Red;
                bu14.BackgroundColor = Color.Blue;
                bu15.BackgroundColor = Color.Red;
                bu16.BackgroundColor = Color.Red;
            }

            if (rand == "3")
            {
                bu1.Text = "5";
                bu2.Text = "6";
                bu3.Text = "10";
                bu4.Text = "7";
                bu5.Text = "4";
                bu6.Text = "1";
                bu7.Text = "13";
                bu8.Text = "2";
                bu9.Text = "9";
                bu10.Text = "3";
                bu11.Text = "11";
                bu12.Text = "12";
                bu13.Text = "15";
                bu14.Text = "8";
                bu15.Text = "14";
                bu16.Text = "";
                bu1.BackgroundColor = Color.Blue;
                bu2.BackgroundColor = Color.Red;
                bu3.BackgroundColor = Color.Blue;
                bu4.BackgroundColor = Color.Blue;
                bu5.BackgroundColor = Color.Blue;
                bu6.BackgroundColor = Color.Red;
                bu7.BackgroundColor = Color.Blue;
                bu8.BackgroundColor = Color.Blue;
                bu9.BackgroundColor = Color.Red;
                bu10.BackgroundColor = Color.Red;
                bu11.BackgroundColor = Color.Red;
                bu12.BackgroundColor = Color.Blue;
                bu13.BackgroundColor = Color.Blue;
                bu14.BackgroundColor = Color.Red;
                bu15.BackgroundColor = Color.Red;
                bu16.BackgroundColor = Color.Red;
            }
        }
    }
}