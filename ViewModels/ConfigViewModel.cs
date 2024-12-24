using MarkaApp.Services;

namespace MarkaApp.ViewModels
{
	public partial class ConfigViewModel
	{
		private readonly ISettingsService _settingsService;
		public ConfigViewModel(ISettingsService settingsService)
		{
			_settingsService = settingsService;
		}

		public async Task LoadData()
		{
			
		}


	}
}
