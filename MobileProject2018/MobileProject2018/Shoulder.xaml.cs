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
	public partial class Shoulder : ContentPage
	{
		public Shoulder ()
		{
			InitializeComponent ();
		}

        // Navigate to Overhead Press page
        async private void OverheadPress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shoulder_OverheadPress());
        }

        // Navigate to Front Raise page
        async private void FrontRaise_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shoulder_FrontRaise());
        }

        // Navigate to Lateral Raise page
        async private void DumbbellLatRaise_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shoulder_LateralRaise());
        }
    }
}