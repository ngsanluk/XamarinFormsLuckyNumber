using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsLuckyNumber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnPlay(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("OnPlay() is called");
            Random random = new Random();
            int number = random.Next(1, 100);
            luckyNumber.Text = number.ToString();
        }
    }
}
