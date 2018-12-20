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
	public partial class Week_Tuesday : ContentPage
	{
		public Week_Tuesday ()
		{
			InitializeComponent ();
		}

        // Navigate to Back page
        async private void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Back());
        }

        // Navigate to Leg2 page 
        async private void Leg2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leg2());
        }

        // Navigate to Tricep page
        async private void Triceps_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tricep());
        }
    }
}