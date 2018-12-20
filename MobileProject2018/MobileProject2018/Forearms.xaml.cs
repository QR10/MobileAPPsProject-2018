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
	public partial class Forearms : ContentPage
	{
		public Forearms ()
		{
			InitializeComponent ();
		}

        // Navigate to Behind Back Wrist Curls page
        async private void BehindBackWristCurls_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forearms_WristCurlBB());
        }

        // Navigate to Seated Wrist Curls page
        async private void SeatedWristCurls_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forearms_SeatedWristCurls());
        }
    }
}