using System.Threading.Tasks;
using Xamarin.Forms;
using XFArtStore.ViewModel;
using XFArtStore.Views;

namespace XFArtStore.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NavigateToHomePageCommand = new Command(async () => ExecuteNavigateToHomePageCommand());
        }

        public Command NavigateToHomePageCommand { get; }

        private async Task ExecuteNavigateToHomePageCommand()
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
