
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

namespace Bagtyyar
{
	[Activity(Label = "MainActivity")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.MainLayout);
			TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
			textView1.Text = Globals.SelectedLanguage.ToString();
		}

		protected override void OnStart()
		{
			base.OnStart();
			TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
			textView1.Text = Globals.SelectedLanguage.ToString();
		}
	}
}

