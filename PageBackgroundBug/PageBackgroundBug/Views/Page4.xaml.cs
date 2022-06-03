using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageBackgroundBug.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}