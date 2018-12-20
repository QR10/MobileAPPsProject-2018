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
	public partial class Login : ContentPage
	{
        public Login()
        {
            InitializeComponent();
            CheckForUsers();   
        }

        // Checks if a profile already exist and displays accordingly
        private void CheckForUsers()
        {
            if (Application.Current.Properties.ContainsKey("FirstName"))
            {
                string fName = Application.Current.Properties["FirstName"].ToString();
                string lName = Application.Current.Properties["LastName"].ToString();
                username.Text = fName + " " + lName;
                

                createProfile.IsVisible = false;
                login.IsVisible = true;
                delete.IsVisible = true;
            }
            else
            {
                username.Text = "Please create a Profile to continue!";
                createProfile.IsVisible = true;
                login.IsVisible = false;
                delete.IsVisible = false;
            }
        }

        // Navigate to Create Profile page
        async private void CreateProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_Profile());
        }

        // Navigate to Week page    
        async private void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Week());
        }

        // Deleting user profile
        private void Delete_Clicked(object sender, EventArgs e)
        {
            //Remove Profile 
            if (Application.Current.Properties.ContainsKey("FirstName"))
            {
                Application.Current.Properties.Remove("FirstName");
                Application.Current.Properties.Remove("LastName");
                DisplayAlert("Success", "Profile removed!", "OK");

                // Refresh labels and buttons after deleting user
                CheckForUsers();
            }
        }
    }
}