using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace MarkaApp
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			//builder.Services.AddTransient<MainPage>();


			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

			builder.AddAppSettings();

			string serverIP = builder.Configuration.GetValue<string>("ServerIp");
			string serverPort = builder.Configuration.GetValue<string>("ServerPort");
#if DEBUG
			builder.Logging.AddDebug();
#endif
			//var app = builder.Build();

			//Services = app.Services;

			//return app;

			return builder.Build();
		}
		//public static IServiceProvider Services { get; private set; }
		private static void AddAppSettings(this MauiAppBuilder builder)
		{

			using Stream stream = Assembly.
				GetExecutingAssembly()
				.GetManifestResourceStream("MarkaApp.appsettings.json");
			if (stream != null)
			{
				IConfiguration config = new ConfigurationBuilder()
					.AddJsonStream(stream)
					.Build();


				builder.Configuration.AddConfiguration(config);
			}
		}
	}
}
