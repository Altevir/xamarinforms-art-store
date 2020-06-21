using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFArtStore.Models;
using XFArtStore.ViewModels;

namespace XFArtStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Painting painting)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, painting);
        }
    }
}