using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VijayAnand.MauiToolkit.Core.Services;

namespace MauiApp1.ViewModels
{
	public abstract partial class BaseViewModel : ObservableObject
	{
		public BaseViewModel(IDialogService dialogService, INavigationService navigationService, ISemanticScreenReader screenReader)
		{
			DialogService = dialogService;
			NavigationService = navigationService;
			ScreenReader = screenReader;
		}

		public IDialogService DialogService { get; protected set; }

		public INavigationService NavigationService { get; protected set; }

		public ISemanticScreenReader ScreenReader { get; protected set; }

		[RelayCommand]
		private async Task NewItem()
		{
			await DialogService.DisplayAlertAsync("Message", "New menu item clicked.", "OK");
		}

		[RelayCommand]
		private async Task Exit()
		{
			if (await DialogService.DisplayAlertAsync("Confirm", "Do you want to close the app?.", "Yes", "No"))
			{
				Application.Current.Quit();
			}
		}
	}
}
