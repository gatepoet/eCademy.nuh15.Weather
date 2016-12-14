using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace eCademy.nuh15.Weather
{
    public class TimeSeriesType
    {
        public const string DailyValues = "0";
    }

    public class Station
    {
        public Station(int stNr, string name, string department)
        {
            Number = stNr;
            Name = name;
            Department = department;
        }

        public int Number { get; private set; }
        public string Name { get; private set; }
        public string Department { get; private set; }
    }
}