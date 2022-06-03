using PageBackgroundBug.Resources.AppThemes;

using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageBackgroundBug.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		bool _isDarkAppTheme;

		public ICommand ChangeAppThemeCommand => new Command(ChangeAppTheme);
		public ICommand ToPage4Command => new Command(async () => await App.Current.MainPage.Navigation.PushAsync(new Page4()));

		public Page3()
		{
			InitializeComponent();

			BindingContext = this;
		}

		public void ChangeAppTheme()
		{
			var mergedDictionaries = Application.Current.Resources.MergedDictionaries;

			mergedDictionaries.Clear();

			if(!_isDarkAppTheme)
			{
				mergedDictionaries.Add(new DarkTheme());

				_isDarkAppTheme = true;
			}	
			else
			{
				mergedDictionaries.Add(new LightTheme());

				_isDarkAppTheme = false;
			}
		}
	}
}