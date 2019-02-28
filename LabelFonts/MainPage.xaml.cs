using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabelFonts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void MudarFonte(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] fonte =
            {"DancingScript-Bold.ttf#DancingScript-Bold",
            "Pacifico-Regular.ttf#Pacifico-Regular",
            "IndieFlower.ttf#IndieFlower"
            };
            label_01.FontFamily = fonte[random.Next(0, fonte.Length - 1)];
            label_02.FontFamily = fonte[random.Next(0, fonte.Length - 1)];
            label_03.FontFamily = fonte[random.Next(0, fonte.Length - 1)];
        }
    }
}
