﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Bagtyyar
{
	public class RestaurantPageFragment : Fragment
	{
		Button detailsButton;
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.RestaurantPageLayout, container, false);

			detailsButton = view.FindViewById<Button>(Resource.Id.button1);
			detailsButton.Click += (sender, e) =>
			{
				
			};
			return view;
		}
	}
}

