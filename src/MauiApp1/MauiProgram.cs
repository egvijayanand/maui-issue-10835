using MauiApp1.ViewModels;
using Microsoft.Extensions.Logging;
using VijayAnand.MauiToolkit;

namespace MauiApp1
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder.UseMauiApp<App>()
				   .UseVijayAnandMauiToolkit()
				   .ConfigureFonts(fonts =>
				   {
					   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				   })
				   .ConfigureServices(services =>
				   {
					   // Singletons
					   services.AddSingleton(SemanticScreenReader.Default);
					   services.AddSingleton<MainViewModel>();
					   services.AddSingleton<MainPage>();
					   // Scoped
					   // Transients
					   services.AddTransient<DesktopPage>();
				   });
#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
