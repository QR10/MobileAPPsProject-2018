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
	public partial class Calculators : ContentPage
	{
		public Calculators ()
		{
			InitializeComponent ();
		}

        // Navigate to BMI Calculator page
        async private void BMI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMI_Calculator());
        }
    }
}