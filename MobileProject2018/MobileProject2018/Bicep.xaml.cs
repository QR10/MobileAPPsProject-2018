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
	public partial class Bicep : ContentPage
	{
		public Bicep ()
		{
			InitializeComponent ();
		}
        
        // Navigate to Standing Barbell Curl page
        async private void BarbellCurl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bicep_StandingCurl());
        }

        // Navigate to Preacher Curl page
        async private void PreacherCurl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bicep_PreacherCurl());
        }
    }
}