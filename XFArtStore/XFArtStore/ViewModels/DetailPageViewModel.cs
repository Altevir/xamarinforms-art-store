using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFArtStore.Models;
using XFArtStore.ViewModel;

namespace XFArtStore.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, Painting painting)
        {
            Navigation = navigation;
            Painting = painting;
            PopDetailPageCommand = new Command(async () => await ExecuteNavigateToDetailPageCommand());
            GetRating();
        }

        public Command PopDetailPageCommand { get; }
        public Painting Painting { get; set; }

        public ObservableCollection<Star> Stars { get; } = new ObservableCollection<Star>();

        void GetRating()
        {
            for (int i = 0; i < Painting.rating; i++)
            {
                Stars.Add(new Star()
                {
                    image = "star.png"
                });
            }
        }

        private async Task ExecuteNavigateToDetailPageCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
