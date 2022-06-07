using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DroidSplashIcon.Droid
{
    [Activity(Label = "DroidSplashIcon", 
        Theme = "@style/Theme.App.Starting", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            var splashScreen = AndroidX.Core.SplashScreen.SplashScreen.InstallSplashScreen(this);

            if (DeviceInfo.Version.Major < 12) //ensure we apply the MainTheme after the splash screen for older versions of Android (Android 12 does the switch automatically on the style)
            {
                base.SetTheme(Resource.Style.MainTheme);
            }

            base.OnCreate(bundle);
            
            Xamarin.Essentials.Platform.Init(this, bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            FormsMaterial.Init(this, bundle);

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}