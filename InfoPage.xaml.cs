namespace MarkaApp;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();

		SemanticScreenReader.Announce(BackBtn.Text);
	}
}