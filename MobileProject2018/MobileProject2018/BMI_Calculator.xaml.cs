using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProject2018
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BMI_Calculator : ContentPage
	{
		public BMI_Calculator ()
		{
			InitializeComponent ();
        }

        // Calculaing BMI of the user and displaying answer on alert
        private void CalculateBMI_Clicked(object sender, EventArgs e)
        {
                string answer = "Your BMI is: ";

                double userHeight = Convert.ToDouble(height.Text);
                double userWeight = Convert.ToDouble(weight.Text);

                double ansBMI = userWeight / (userHeight * userHeight);

                answer += String.Format("{0:0.##}", ansBMI);


                if (ansBMI < 18.5)
                    answer += "\n You are Underweight!";
                else if (ansBMI < 25)
                    answer += "\n You are on your Healthy weight!";
                else if (ansBMI < 30)
                    answer += "\n You are Overweight!";
                else
                    answer += "\n You are Obese!";

                DisplayAlert("BMI Calculator", answer, "Ok");
        }

        private void BMITable_Clicked(object sender, EventArgs e)
        {
            string tableContent = "If your BMI is less than 18.5 you are under your ideal weight. \n\n" +
                "If your BMI is greater than or equal to 18.5 and less than 25 you are at your ideal weight.\n\n" +
                "If your BMI is greater than or equal to 25 and less than 30 you are over your ideal weight.\n\n" +
                "If your BMI is greater than or equal to 30 you are within the obese category.";
            DisplayAlert("BMI Table", tableContent, "Ok");
        }
    }
}