using CommunityToolkit.Mvvm.DependencyInjection;

namespace MauiApp1
{
	public class ServiceLocator : IMauiInitializeService
	{
		public void Initialize(IServiceProvider services)
		{
			Ioc.Default.ConfigureServices(services);
		}
	}
}
