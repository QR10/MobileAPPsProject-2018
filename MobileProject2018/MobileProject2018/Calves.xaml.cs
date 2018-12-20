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
	public partial class Calves : ContentPage
	{
		public Calves ()
		{
			InitializeComponent ();
		}

        // Navigate to Standing Calve raise page
        async private void StandingCalveRaise_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calves_StandingRaise());
        }

        // Navigate to Seated Calve Raise page
        async private void SeatedCalveRaise_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calves_SeatedRaise());
        }
    }
}