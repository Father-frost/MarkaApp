﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace MarkaApp
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			var a = Assembly.GetExecutingAssembly();
			using var stream = a.GetManifestResourceStream("MarkaApp.appsettings.json");

			//var config = new ConfigurationBuilder()
			//	.AddJsonStream(stream)
			//	.Build();

			//builder.Configuration.AddConfiguration(config);

			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
