using PageBackgroundBug.Views;

using Xamarin.Forms;

namespace PageBackgroundBug
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainTabbedPage());
		}
	}
}