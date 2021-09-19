using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var enteredNumber = (sender as Button).Text;
            this.phoneNumber.Text += enteredNumber;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            //Logic to make a call
        }
    }
}
