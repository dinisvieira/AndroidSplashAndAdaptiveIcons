using System.Diagnostics;
using Xamarin.Forms;

namespace DroidSplashIcon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //This can be used to log Xamarin Forms Errors
            Xamarin.Forms.Internals.Log.Listeners.Add(new Xamarin.Forms.Internals.DelegateLogListener(async (arg1, arg2) =>
            {
#if DEBUG
                Debug.WriteLine($"XF.I:{arg2}");
#endif
            }));

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
