namespace MarkaApp;

public partial class ConfigPage : ContentPage
{
	public ConfigPage()
	{
		InitializeComponent();
	}

	private async void OnSaveClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();

		SemanticScreenReader.Announce(SaveBtn.Text);
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();

		SemanticScreenReader.Announce(BackBtn.Text);
	}
}