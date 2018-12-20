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
	public partial class Leg2 : ContentPage
	{
		public Leg2 ()
		{
			InitializeComponent ();
		}

        // Navigate to Leg Curl page
        async private void LegCurl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg_Curl());
        }

        async private void LegPress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg_Press());
        }
    }
}