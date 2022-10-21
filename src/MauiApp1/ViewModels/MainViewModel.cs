using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VijayAnand.MauiToolkit.Core.Services;

namespace MauiApp1.ViewModels
{
	public partial class MainViewModel : BaseViewModel
	{
		private int count = 0;

		public MainViewModel(IDialogService dialogService, INavigationService navigationService, ISemanticScreenReader screenReader)
			: base(dialogService, navigationService, screenReader)
		{

		}

		[ObservableProperty]
		private string countText = "Click me";

		[RelayCommand]
		private void Count()
		{
			count++;
			CountText = count switch
			{
				1 => "Clicked 1 time",
				_ => $"Clicked {count} times"
			};

			ScreenReader.Announce(CountText);
		}

		[RelayCommand]
		private async Task NavigateAsync()
		{
			await NavigationService.GoToAsync("desktop");
		}

		public static async IAsyncEnumerable<int> GenerateSequence()
		{
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(100);
				yield return i;
			}
		}
	}
}
