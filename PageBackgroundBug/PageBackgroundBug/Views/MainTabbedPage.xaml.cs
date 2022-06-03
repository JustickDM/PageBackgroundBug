using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageBackgroundBug.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainTabbedPage : TabbedPage
	{
		public ICommand ToPage3Command => new Command(async () => await App.Current.MainPage.Navigation.PushAsync(new Page3()));

		public MainTabbedPage()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}