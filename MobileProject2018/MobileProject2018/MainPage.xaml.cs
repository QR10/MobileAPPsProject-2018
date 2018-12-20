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
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
            InitializeComponent ();
		}

        // Navigate to Login page
        async private void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        // Navigate to Calculators page
        async private void Calculators_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculators());
        }

        // Alert Disclaimer
        private void Disclaimer_Clicked(object sender, EventArgs e)
        {
            string message = "This application contains copyrighted material the use of which has not been specifically authorized by the copyright owner. " +
            "In accord with our nonprofit and educational mission, we are making such material available to guide people on a workout routine. " +
            "We believe this constitutes a 'fair use' of any such copyrighted material as provided in Section 107 of the US Copyright Law. " +
            "In accordance with Title 17 U.S.C Section 107, the material on this application is distributed without profit to those who have " +
            "expressed prior interest in receiving the included information for research and educational purposes. " + 
            "To any owners of these materials that do not wish for it to be shown in this application, please contact us and we will remove it instantly. ";
            

            DisplayAlert("Disclaimer", message, "Ok");
        }
    }
}