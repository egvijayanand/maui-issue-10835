namespace MauiApp1
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			RegisterRoutes();
		}
		static void RegisterRoutes()
		{
			Routing.RegisterRoute("desktop", typeof(DesktopPage));
		}
	}
}
