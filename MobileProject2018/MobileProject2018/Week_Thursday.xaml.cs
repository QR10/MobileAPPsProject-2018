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
	public partial class Week_Thursday : ContentPage
	{
		public Week_Thursday ()
		{
			InitializeComponent ();
		}

        // Nagivate to Chest Page
        async private void Chest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chest());
        }

        // Navigate to Bicep page
        async private void Biceps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bicep());
        }

        // Navigate to Legs page
        async private void Legs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg());
        }
    }
}