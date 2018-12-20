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
	public partial class Back : ContentPage
	{
		public Back ()
		{
			InitializeComponent ();
		}

        // Navigate to Lat Pulldown page
        async private void LatPulldown_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Back_LatPulldown());
        }

        // Navigate to Seated Cable Row page
        async private void SeatedRow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Back_SeatedRow());
        }

        // Navigate to Tripod Dumbbell Row page
        async private void DumbbellRow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Back_DumbbellRow());
        }
    }
}