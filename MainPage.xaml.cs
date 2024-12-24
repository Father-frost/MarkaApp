using Microsoft.Extensions.Configuration;
using System.Security.AccessControl;

namespace MarkaApp
{
	public partial class MainPage : ContentPage
	{
		IConfiguration configuration;

		//public MainPage()
		//{
		//	InitializeComponent();
		//}

		public MainPage()
		{
			InitializeComponent();
			//configuration = MauiProgram.Services.GetService<IConfiguration>();
			//ConfigBtn.Text = configuration["port"];
		}

		private async void OnInfoClicked(object sender, EventArgs e)
		{
			////await Navigation.PushAsync(new InfoPage());
			//var settings = configuration.GetRequiredSection("ServerConfig").Get<Settings>();
			//await DisplayAlert("ServerConfig", $"{nameof(settings.ServerIp)}: {settings.ServerIp}" +
			//	$"{nameof(settings.ServerPort)}: {settings.ServerPort}", "OK");
			SemanticScreenReader.Announce(InfoBtn.Text);
		}

		private async void OnConfigClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConfigPage());

			SemanticScreenReader.Announce(InfoBtn.Text);
		}

		private void OnPackAgregateClicked(object sender, EventArgs e)
		{
			//SemanticScreenReader.Announce(PackAgregateBtn.Text);
		}
		private void OnPalletAgregateClicked(object sender, EventArgs e)
		{
			//SemanticScreenReader.Announce(PalletAgregateBtn.Text);
		}
		private async void OnChangeInPackClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ChangeInPackPage());
			//SemanticScreenReader.Announce(ChangeInPackBtn.Text);
		}
		private void OnChangeInPalletClicked(object sender, EventArgs e)
		{
			//SemanticScreenReader.Announce(ChangeInPalletBtn.Text);
		}
	}

}
