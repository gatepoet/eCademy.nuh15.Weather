using System;
using Android.App;
using Android.OS;
using eCademy.nuh15.Weather.no.met.eklima;
using System.Linq;
using Android.Widget;

namespace eCademy.nuh15.Weather
{
    [Activity(Label = "Select station")]
    public class SelectStationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.SelectStation);

            LoadStations();
        }

        private void LoadStations()
        {
            var service = new MetDataService();
            var result = service.getStationsFromTimeserieType(TimeSeriesType.DailyValues, "");
            var stations = result.Select(s => new Station(s.stnr, s.name, s.department));

            FindViewById<ExpandableListView>(Resource.Id.stations)
                .SetAdapter(new StationAdapter(this, stations));
        }
    }
}