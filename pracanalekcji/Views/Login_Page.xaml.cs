using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pracanalekcji.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login_Page : ContentPage
	{
		public Login_Page ()
		{
			InitializeComponent ();
		}

        private async void Login_Clicked(object sender, EventArgs e)
        {
            var users = await App.Database.GetUsersFilter(loginEntry.Text, passwordEntry.Text);
            if (users.Count == 0)
            {
                DisplayAlert("Info", "Podano błędne dane", "OK");
                return;
            }

            var user = users[0];
            Navigation.PushAsync(new MainPage(user));
        }
    }
}