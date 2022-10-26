using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCodeKeyboard
{
    public partial class MainPage : ContentPage
    {
        private string sentence { get; set; }
        private string dotsAndDashes { get; set; }
        private string dotsAndDashes2 { get; set;  }

        public MainPage()
        {
            // has to be here for each page
            InitializeComponent();
            sentence = "";
            dotsAndDashes = "";
        }

        void ButtonClicked(object sender, EventArgs args)
        {

            switch(((Button)sender).Text)
            {
                case ".":
                    if(((Button)sender).ClassId == "dot1")
                    {
                        dotsAndDashes += ".";
                        outputMorseText.Text = dotsAndDashes;
                    }
                    else if (((Button)sender).ClassId == "dot2")
                    {
                        dotsAndDashes2 += ".";
                        outputMorseText2.Text = dotsAndDashes2;
                    }

                    break;
                case "-":
                    if (((Button)sender).ClassId == "dash1")
                    {
                        dotsAndDashes += "-";
                        outputMorseText.Text += ".";
                    }
                    else if (((Button)sender).ClassId == "dash2")
                    {
                        dotsAndDashes2 += "-";
                        outputMorseText2.Text += dotsAndDashes2;
                    }
                    break;
                default:
                    if (((Button)sender).ClassId == "space1")
                    {
                        outputText.Text += Morse.MorseCoder(dotsAndDashes);
                        dotsAndDashes = "";
                    }
                    else if (((Button)sender).ClassId == "space2")
                    {
                        outputText2.Text += Morse.MorseCoder(dotsAndDashes2);
                        dotsAndDashes2 = "";
                    }

                    break;
            }
            outputMorseText.Text = dotsAndDashes;
            outputMorseText2.Text = dotsAndDashes2;

        }
    }
}
