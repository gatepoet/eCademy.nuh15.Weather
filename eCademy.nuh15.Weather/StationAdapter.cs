using System;
using Android.Views;
using Android.Widget;
using Android.App;
using System.Collections;
using System.Collections.Generic;
using Java.Lang;
using System.Linq;

namespace eCademy.nuh15.Weather
{
    public class StationAdapter : BaseExpandableListAdapter
    {
        private Activity activity;
        private List<KeyValuePair<string, List<Station>>> stationsByDepartment;

        public StationAdapter(Activity activity, IEnumerable<Station> stations)
        {
            this.activity = activity;
            this.stationsByDepartment = stations
                .GroupBy(s => s.Department)
                .Select(g => new KeyValuePair<string, List<Station>>(g.Key, new List<Station>(g)))
                .ToList();
        }

        public override int GroupCount
        {
            get
            {
                return stationsByDepartment.Count;
            }
        }

        public override bool HasStableIds
        {
            get
            {
                return true;
            }
        }

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            return null;
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return stationsByDepartment[groupPosition].Value[childPosition].Number;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            return stationsByDepartment[groupPosition].Value.Count;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            var station = stationsByDepartment[groupPosition].Value[childPosition];

            var view = activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleExpandableListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = station.Name;

            return view;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            return null;
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            View header = convertView;
            if (header == null)
            {
                header = activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }
            var text = header.FindViewById<TextView>(Android.Resource.Id.Text1);
            text.Text = stationsByDepartment[groupPosition].Key;

            return header;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return false;
        }
    }
}