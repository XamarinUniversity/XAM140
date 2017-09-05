using Xamarin.Forms;

namespace TipCalculator
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new StandardTipPage());
		}
	}
}