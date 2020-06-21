using UIKit;
using Xamarin.Forms;
using XFArtStore.Interfaces;
using XFArtStore.iOS.Interfaces;

[assembly: Dependency(typeof(StatusBarStyle))]
namespace XFArtStore.iOS.Interfaces
{
    public class StatusBarStyle : IStatusBarStyle
    {
        public void ChangeTextColor()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var currentUIViewController = GetCurrentViewController();
                UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);
                currentUIViewController.SetNeedsStatusBarAppearanceUpdate();
            });
        }

        UIViewController GetCurrentViewController()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
                vc = vc.PresentedViewController;
            return vc;
        }
    }
}