using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Support.V7.App;

namespace SampleApp.Droid
{
	[Activity(Label = "SampleApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var button = FindViewById<Button>(Resource.Id.myButton);

			Action<object, EventArgs> handleOnButtonClick = (object sender, EventArgs e) =>
			{
				button.Text = $"{count++} clicks!";
			};

			button.Click += (sender, e) => handleOnButtonClick(sender, e);

		}

	}

}