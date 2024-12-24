using Microsoft.Extensions.Configuration;

namespace MarkaApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromArgb("#6834eb"),
				BarTextColor = Colors.White

			};
		}
	}
}
