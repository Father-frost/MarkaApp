using Microsoft.Extensions.Configuration;

namespace MarkaApp
{
	public partial class MainPage : ContentPage
	{
		private readonly IConfiguration _configuration;

		public MainPage()
		{
			InitializeComponent();
		}

		public MainPage(IConfiguration configuration)
		{
			InitializeComponent();
			_configuration = configuration;
			ConfigBtn.Text = _configuration["port"];
		}

		private async void OnInfoClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new InfoPage());

			SemanticScreenReader.Announce(InfoBtn.Text);
		}

		private async void OnConfigClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConfigPage());

			SemanticScreenReader.Announce(InfoBtn.Text);
		}

		private void OnPackAgregateClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(PackAgregateBtn.Text);
		}
		private void OnPalletAgregateClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(PalletAgregateBtn.Text);
		}
		private void OnChangeInPackClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(ChangeInPackBtn.Text);
		}
		private void OnChangeInPalletClicked(object sender, EventArgs e)
		{
			SemanticScreenReader.Announce(ChangeInPalletBtn.Text);
		}
	}

}
