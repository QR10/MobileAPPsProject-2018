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
	public partial class Chest : ContentPage
	{
		public Chest ()
		{
			InitializeComponent ();
		}

        // Navigate to Incline Bench Press page
        async private void IncBenchPress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chest_IncBenchPress());
        }

        // Navigate to Decline Bench Press page
        async private void DecBenchPress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chest_DecBenchPress());
        }

        // Navigate to Pullover page
        async private void Pullover_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chest_Pullover());
        }

        // Navigate to Dumbbell Flys page
        async private void Flys_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chest_Flys());
        }
    }
}