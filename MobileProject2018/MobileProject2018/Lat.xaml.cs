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
	public partial class Lat : ContentPage
	{
		public Lat ()
		{
			InitializeComponent ();
		}

        // Navigate to Dumbbell Shrug page
        async private void DumbbellShrug_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lat_DumbbellShrug());
        }

        // Navigate to Upright Row page
        async private void UprightRow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lat_UprightRow());
        }
    }
}