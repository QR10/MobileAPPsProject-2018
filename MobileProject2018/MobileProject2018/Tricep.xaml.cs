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
	public partial class Tricep : ContentPage
	{
		public Tricep ()
		{
			InitializeComponent ();
		}

        // Navigate to French Press page
        async private void FrenchPress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tricep_FrenchPress());
        }

        // Navigate to Lying Tricep Extension page
        async private void LyingTricepExtension_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tricep_LyingExtension());
        }

        // Navigate to Straight Tricep Extension page
        async private void StraightTricepExtension_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tricep_StraightExtension());
        }
    }
}