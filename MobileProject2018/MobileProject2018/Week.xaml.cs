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
	public partial class Week : ContentPage
	{
		public Week ()
		{
			InitializeComponent ();
		}

        // Navigate to Monday page
        async private void Monday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Monday());
        }

        // Navigate to Tuesday page
        async private void Tuesday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Tuesday());
        }
        
        // Navigate to Wednesday page
        async private void Wednesday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Wednesday());
        }

        // Navigate to Thursday page
        async private void Thursday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Thursday());
        }

        // Navigate to Friday page
        async private void Friday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Friday());
        }

        // Navigate to Saturday page
        async private void Saturday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week_Saturday());
        }
    }
}