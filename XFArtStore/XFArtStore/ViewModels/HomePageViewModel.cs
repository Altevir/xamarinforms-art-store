using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFArtStore.Models;
using XFArtStore.Services;
using XFArtStore.ViewModel;
using XFArtStore.Views;

namespace XFArtStore.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NavigateToDetailPageCommand = new Command<Painting>(async (param) => await ExecuteNavigateToDetailPageCommand(param));
            GetGroups();
            GetPaintings();
            GetTopArtists();
            GetListForYou();
        }

        public Command NavigateToDetailPageCommand { get; }
        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Painting> Paintings { get; set; }
        public ObservableCollection<TopArtists> TopArtists { get; set; }
        public ObservableCollection<ForYou> ListForYou { get; set; }

        void GetGroups()
        {
            Groups = new ObservableCollection<Group>(DataService.GetGroups());
        }

        void GetPaintings()
        {
            Paintings = new ObservableCollection<Painting>(DataService.GetPaintings());
        }

        void GetTopArtists()
        {
            TopArtists = new ObservableCollection<TopArtists>(DataService.GetTopArtists());
        }
        void GetListForYou()
        {
            ListForYou = new ObservableCollection<ForYou>(DataService.GetListForYou());
        }

        private async Task ExecuteNavigateToDetailPageCommand(Painting param)
        {
            await Navigation.PushAsync(new DetailPage(param));
        }
    }
}
