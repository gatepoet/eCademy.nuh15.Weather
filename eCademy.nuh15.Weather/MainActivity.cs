using Android.App;
using Android.Widget;
using Android.OS;

namespace eCademy.nuh15.Weather
{
    [Activity(Label = "eCademy.nuh15.Weather", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

