using Plugin.SimpleAudioPlayer;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace puzzle
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Audio()
        {
            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current; 

            sound.Load("SoundBible.mp3");
   
            sound.Play();
        }

        public void Audio1()
        {
            var sound = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current; ;

            sound.Load("button_click.mp3");

            sound.Play();
        }

        private void Bu_Clicked(object sender, EventArgs e)
        {
            Audio1();
            Rand();
        }
        public string rand="2";
        public void Rand()
        {
            Random r = new Random();
            rand = r.Next(1, 4).ToString();
            if(rand=="1")
            {
                bu1.Text = "8";
                bu1.BackgroundColor = Color.Blue;
                bu2.Text = "2";
                bu2.BackgroundColor = Color.Blue;
                bu3.Text = "5";
                bu3.BackgroundColor = Color.Red;
                bu4.Text = "1";
                bu4.BackgroundColor = Color.Red;
                bu5.Text = "7";
                bu5.BackgroundColor = Color.Red;
                bu6.Text = "3";
                bu6.BackgroundColor = Color.Red;
                bu7.Text = "4";
                bu7.BackgroundColor = Color.Blue;
                bu8.Text = "6";
                bu8.BackgroundColor = Color.Blue;
                bu9.Text = "";
                bu9.BackgroundColor = Color.Red;
                Winer();
            }
            else if (rand == "2")
            {
                bu1.Text = "3";
                bu1.BackgroundColor = Color.Red;
                bu2.Text = "6";
                bu2.BackgroundColor = Color.Blue;
                bu3.Text = "8";
                bu3.BackgroundColor = Color.Blue;
                bu4.Text = "7";
                bu4.BackgroundColor = Color.Red;
                bu5.Text = "5";
                bu5.BackgroundColor = Color.Red;
                bu6.Text = "4";
                bu6.BackgroundColor = Color.Blue;
                bu7.Text = "1";
                bu7.BackgroundColor = Color.Red;
                bu8.Text = "2";
                bu8.BackgroundColor = Color.Blue;
                bu9.Text = "";
                bu9.BackgroundColor = Color.Red;
                Winer();
            }
            else
            {
                bu1.Text = "4";
                bu1.BackgroundColor = Color.Blue;
                bu2.Text = "5";
                bu2.BackgroundColor = Color.Red;
                bu3.Text = "3";
                bu3.BackgroundColor = Color.Red;
                bu4.Text = "2";
                bu4.BackgroundColor = Color.Blue;
                bu5.Text = "6";
                bu5.BackgroundColor = Color.Blue;
                bu6.Text = "8";
                bu6.BackgroundColor = Color.Blue;
                bu7.Text = "1";
                bu7.BackgroundColor = Color.Red;
                bu8.Text = "7";
                bu8.BackgroundColor = Color.Red;
                bu9.Text = "";
                bu8.BackgroundColor = Color.Red;
                Winer();
            }

        }
       public Color co = new Color();
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
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu1.Text;
                bu1.Text = "";
                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu1.BackgroundColor;
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
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu4.Text;
                bu4.Text = bu1.Text;
                bu1.Text = "";
                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = bu1.BackgroundColor;
                bu1.BackgroundColor = co;
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
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu2.Text;
                bu2.Text = "";
                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu5.Text;
                bu5.Text = bu2.Text;
                bu2.Text = "";
                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu2.BackgroundColor;
                bu2.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu3_Clicked(object sender, EventArgs e)
        {
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu3.Text;
                bu3.Text = "";
                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu3.Text;
                bu3.Text = "";
                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu3.BackgroundColor;
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
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu6.Text;
                bu6.Text = bu3.Text;
                bu3.Text = "";
                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu3.BackgroundColor;
                bu3.BackgroundColor = co;
            }
             Winer();
        }

        private void Bu4_Clicked(object sender, EventArgs e)
        {
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu4.Text;
                bu4.Text = "";
                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu4.Text;
                bu4.Text = "";
                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu4.Text;
                bu4.Text = "";
                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu5.Text;
                bu5.Text = bu4.Text;
                bu4.Text = "";
                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu5_Clicked(object sender, EventArgs e)
        {
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu5.Text;
                bu5.Text = "";
                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu5.Text;
                bu5.Text = "";
                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu5.BackgroundColor;
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
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu5.Text;
                bu5.Text = "";
                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu6_Clicked(object sender, EventArgs e)
        {
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu6.Text;
                bu6.Text = "";
                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu6.Text;
                bu6.Text = "";
                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu6.Text;
                bu6.Text = "";
                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu5.Text;
                bu5.Text = bu6.Text;
                bu6.Text = "";
                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu7_Clicked(object sender, EventArgs e)
        {
            if (bu4.Text == "")
            {
                Audio();
                bu4.Text = bu7.Text;
                bu7.Text = "";
                co = bu4.BackgroundColor;
                bu4.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu7.Text;
                bu7.Text = "";
                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu1.Text == "")
            {
                Audio();
                bu1.Text = bu4.Text;
                bu4.Text = bu7.Text;
                bu7.Text = "";
                co = bu1.BackgroundColor;
                bu1.BackgroundColor = bu4.BackgroundColor;
                bu4.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu8.Text;
                bu8.Text = bu7.Text;
                bu7.Text = "";
                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu7.BackgroundColor;
                bu7.BackgroundColor = co;
            }
            Winer();
        }

        private void Bu8_Clicked(object sender, EventArgs e)
        {
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu8.Text;
                bu8.Text = "";
                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu9.Text == "")
            {
                Audio();
                bu9.Text = bu8.Text;
                bu8.Text = "";
                co = bu9.BackgroundColor;
                bu9.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu5.Text == "")
            {
                Audio();
                bu5.Text = bu8.Text;
                bu8.Text = "";
                co = bu5.BackgroundColor;
                bu5.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
            if (bu2.Text == "")
            {
                Audio();
                bu2.Text = bu5.Text;
                bu5.Text = bu8.Text;
                bu8.Text = "";
                co = bu2.BackgroundColor;
                bu2.BackgroundColor = bu5.BackgroundColor;
                bu5.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = co;
            }
             Winer();
        }

        private void Bu9_Clicked(object sender, EventArgs e)
        {
            if (bu6.Text == "")
            {
                Audio();
                bu6.Text = bu9.Text;
                bu9.Text = "";
                co = bu6.BackgroundColor;
                bu6.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu8.Text == "")
            {
                Audio();
                bu8.Text = bu9.Text;
                bu9.Text = "";
                co = bu8.BackgroundColor;
                bu8.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu7.Text == "")
            {
                Audio();
                bu7.Text = bu8.Text;
                bu8.Text = bu9.Text;
                bu9.Text = "";
                co = bu7.BackgroundColor;
                bu7.BackgroundColor = bu8.BackgroundColor;
                bu8.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
            if (bu3.Text == "")
            {
                Audio();
                bu3.Text = bu6.Text;
                bu6.Text = bu9.Text;
                bu9.Text = "";
                co = bu3.BackgroundColor;
                bu3.BackgroundColor = bu6.BackgroundColor;
                bu6.BackgroundColor = bu9.BackgroundColor;
                bu9.BackgroundColor = co;
            }
             Winer();
        }

        public void Winer()
        {
            Le.Text = "play";
            if (bu1.Text == "1" && bu2.Text == "2" && bu3.Text == "3"
                && bu4.Text == "4" && bu5.Text == "5" && bu6.Text == "6"
                && bu7.Text == "7" && bu8.Text == "8" && bu9.Text=="")
            {
                bu9.Text = "9";
                Le.Text = "winer 😃";
            }
        }
    }
}
