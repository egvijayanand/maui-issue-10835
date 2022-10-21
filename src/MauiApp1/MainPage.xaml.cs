using MauiApp1.ViewModels;

namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage(MainViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}

		protected override void OnNavigatedTo(NavigatedToEventArgs args)
		{
			base.OnNavigatedTo(args);
			// Uncomment to make the MenuBar item commands to work again after navigation.
			//fileMenu.BindingContext ??= BindingContext;
		}
	}
}
