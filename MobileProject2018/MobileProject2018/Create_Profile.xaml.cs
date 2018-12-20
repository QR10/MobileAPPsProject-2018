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
	public partial class Create_Profile : ContentPage
	{
		public Create_Profile ()
		{
			InitializeComponent ();
		}

        // Creates and stores the new profile
        private void BtnStore_Clicked(object sender, EventArgs e)
        {
            // Store name
            Application.Current.Properties["FirstName"] = txtFirstName.Text;
            Application.Current.Properties["LastName"] = txtLastName.Text;
            DisplayAlert("Success", "Profile created successfully", "Continue");
            
            // Back button problem work around in navigation 
            Navigation.PushAsync(new MainPage());
            Navigation.PushAsync(new Login());
        }

    }
}