using System;
using Android.App;
using Android.Widget;
using Android.Content;
using Android.Views;

namespace Bagtyyar
{
	public class AdminPage
	{
		AlertDialog.Builder alert;
		View content;
		EditText servicePathEditText;
		EditText defaultRoomIdEditText;
		EditText videosPathEditText;
		EditText tvPlaylistPathEditText;
		EditText imagesPathEditText;
		EditText stringsPathEditText;


		public AdminPage(LanguagesActivity parent)
		{
			alert = new AlertDialog.Builder(parent);
			content = parent.LayoutInflater.Inflate(Resource.Layout.AdminLayout, null);
			alert.SetView(content);
			alert.SetTitle("Settings");
			alert.SetPositiveButton("Close", delegate {  });
			alert.SetNegativeButton("Clear settings", delegate {
				var confAlert = new AlertDialog.Builder(parent);
				confAlert.SetTitle("Are you sure?");
				confAlert.SetMessage("If you press YES we will erase all settings, do you want to proceed?");
				confAlert.SetPositiveButton("Yes", delegate {
					Settings.CurrentSettings.ClearSettings();
				});
				confAlert.SetNegativeButton("No", delegate { });
				confAlert.Create().Show();
			});

			alert.Create();
			AssignHandlers();

		}

		public void AssignHandlers()
		{
			servicePathEditText = content.FindViewById<EditText>(Resource.Id.editTextServicePath);
			defaultRoomIdEditText = content.FindViewById<EditText>(Resource.Id.editTextDefaultRoomId); ;
			videosPathEditText = content.FindViewById<EditText>(Resource.Id.editTextVideosPath); ;
			tvPlaylistPathEditText = content.FindViewById<EditText>(Resource.Id.editTextTVPlaylistPath); ;
			imagesPathEditText = content.FindViewById<EditText>(Resource.Id.editTextImagesPath); ;
			stringsPathEditText = content.FindViewById<EditText>(Resource.Id.editTextStringsPath); ;

			servicePathEditText.Text = Settings.CurrentSettings.ServicePath;
			defaultRoomIdEditText.Text = Settings.CurrentSettings.DefaultRoomId;
			videosPathEditText.Text = Settings.CurrentSettings.VideosPath;
			tvPlaylistPathEditText.Text = Settings.CurrentSettings.TvPlaylistPath;
			imagesPathEditText.Text = Settings.CurrentSettings.ImagesPath;
			stringsPathEditText.Text = Settings.CurrentSettings.StringsPath;

			servicePathEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.ServicePath = servicePathEditText.Text;
			};

			defaultRoomIdEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.DefaultRoomId = defaultRoomIdEditText.Text;
			};

			videosPathEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.VideosPath = defaultRoomIdEditText.Text;
			};

			tvPlaylistPathEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.TvPlaylistPath = tvPlaylistPathEditText.Text;
			};

			imagesPathEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.ImagesPath = imagesPathEditText.Text;
			};

			stringsPathEditText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
			{
				Settings.CurrentSettings.StringsPath = stringsPathEditText.Text;
			};
		}

		public void Show()
		{
			alert.Show();
		}
	}
}

