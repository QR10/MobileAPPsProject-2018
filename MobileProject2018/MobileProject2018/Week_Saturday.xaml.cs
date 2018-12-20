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
	public partial class Week_Saturday : ContentPage
	{
		public Week_Saturday ()
		{
			InitializeComponent ();
		}

        // Navigate to Shoulders page
        async private void Shoulders_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shoulder());
        }

        // Navigate to Calves page
        async private void Calves_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calves());
        }

        // Navigate to Forearms page
        async private void Forearms_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forearms());
        }

        // Navigate to Lats page
        async private void Lats_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lat());
        }
    }
}