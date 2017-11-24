using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double h = double.Parse(Height.Text);
            double w = double.Parse(Weight.Text);

            DisplayAlert("身長", h.ToString(), "OK");
            DisplayAlert("体重", w.ToString(), "OK");

            string s;

            if (h > 3)
            {
                h /= 100;
            }

            if (BMI >= 25)
            {
                s = "肥満";
            }

            else if (BMI > 18.5)
            {
                s = "普通体重";
            }

            else
            {
                s = "低体重";
            }
            return s;

            double bmi = w / h / h;
            DisplayAlert("BMI", bmi.ToString(), "OK");
        }
    }
}
