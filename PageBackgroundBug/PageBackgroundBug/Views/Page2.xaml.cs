using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageBackgroundBug.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}