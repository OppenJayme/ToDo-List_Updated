using Microsoft.Maui.Controls;
using System.Threading.Tasks;


namespace TodoListApp1.Page
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        //private async void GoToSignUp(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SignUpPage());
        //}

        private async void OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

    }

}