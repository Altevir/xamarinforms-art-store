using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFArtStore.Models;
using XFArtStore.ViewModels;

namespace XFArtStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        Label elementSelected;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel(Navigation);

            var childrens = stackGroups.Children;
            foreach (var item in childrens)
            {
                var tapGesture = new TapGestureRecognizer();
                tapGesture.Tapped += Label_Tapped;
                item.GestureRecognizers.Add(tapGesture);

                if (item is Label)
                {
                    var label = (Label)item;
                    if (label.Text.Equals("All"))
                    {
                        label.TextColor = Color.FromHex("#FFCA06");
                        elementSelected = label;
                    }
                }
            }
        }

        private void Label_Tapped(object sender, System.EventArgs e)
        {
            if (elementSelected != null)
                VisualStateManager.GoToState(elementSelected, "UnSelected");

            VisualStateManager.GoToState((Label)sender, "Selected");
            elementSelected = (Label)sender;
        }
    }
}