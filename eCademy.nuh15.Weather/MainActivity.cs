using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;

namespace eCademy.nuh15.Weather
{
    [Activity(Label = "eCademy.nuh15.Weather", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public class RequestCodes
        {
            public const int SelectStation = 0;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            Button selectStation = FindViewById<Button>(Resource.Id.selectStation);
            selectStation.Click += StartSelectStationActivity;
        }

        private void StartSelectStationActivity(object sender, System.EventArgs e)
        {
            this.StartActivityForResult(new Intent(this, typeof(SelectStationActivity)), RequestCodes.SelectStation);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }
    }
}

