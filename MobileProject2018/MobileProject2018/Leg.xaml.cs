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
	public partial class Leg : ContentPage
	{
		public Leg ()
		{
			InitializeComponent ();
		}

        // Navigate to Squat page
        async private void Squat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg_Squat());
        }

        // Navigate to Leg Extension page
        async private void LegExtension_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg_Extension());
        }
    }
}