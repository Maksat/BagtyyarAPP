
using Android.App;
using Android.OS;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Widget;
using System;
using Android.Media;

namespace Bagtyyar
{
	[Activity(Label = "Bagtyýar",
		  Icon = "@mipmap/icon",
		  Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen"
		 )]
	public class MainActivity : Activity 
	{
		HomePageFragment homePageFragment;
		TVPageFragment tvPageFragment;
		VidePageFragment videoPageFragment;
		RestaurantPageFragment restaurantPageFragment;
		ServicesPageFragment servicesPageFragment;
		EntertainmentPageFragment entertainmentPageFragment;


	    void HomeButtonClick(object sender, EventArgs e)
		{
			ShowFragment(homePageFragment);
		}

		void TVButtonClick(object sender, EventArgs e)
		{
			ShowFragment(tvPageFragment);
		}

		void VideoButtonClick(object sender, EventArgs e)
		{
			ShowFragment(videoPageFragment);
		}

		void RestaurantButtonClick(object sender, EventArgs e)
		{
			ShowFragment(restaurantPageFragment);
		}

		void RoomServiceButtonClick(object sender, EventArgs e)
		{
			ShowFragment(servicesPageFragment);
		}

		void EntertainmentButtonClick(object sender, EventArgs e)
		{
			ShowFragment(entertainmentPageFragment);
		}

		void ShowFragment(Fragment fragment)
		{
			AudioManager.FromContext(this).PlaySoundEffect(SoundEffect.KeyClick);
			FragmentTransaction ft = FragmentManager.BeginTransaction();
			HideAllFragments(ft);
			ft.Show(fragment);
			ft.Commit();
		}

		void HideAllFragments(FragmentTransaction ft)
		{
			ft.Hide(homePageFragment);
			ft.Hide(tvPageFragment);
			ft.Hide(videoPageFragment);
			ft.Hide(restaurantPageFragment);
			ft.Hide(servicesPageFragment);
			ft.Hide(entertainmentPageFragment);
		}

		void CreatePageFragments()
		{
			FragmentTransaction ft = FragmentManager.BeginTransaction();
			homePageFragment = new HomePageFragment();
			tvPageFragment = new TVPageFragment();
			videoPageFragment = new VidePageFragment();
			restaurantPageFragment = new RestaurantPageFragment();
			servicesPageFragment = new ServicesPageFragment();
			entertainmentPageFragment = new EntertainmentPageFragment();


			ft.Add(Resource.Id.mainLinearLayout, homePageFragment);
			ft.Add(Resource.Id.mainLinearLayout, tvPageFragment);
			ft.Add(Resource.Id.mainLinearLayout, videoPageFragment);
			ft.Add(Resource.Id.mainLinearLayout, restaurantPageFragment);
			ft.Add(Resource.Id.mainLinearLayout, servicesPageFragment);
			ft.Add(Resource.Id.mainLinearLayout, entertainmentPageFragment);

			HideAllFragments(ft);
			ft.Show(homePageFragment);

			ft.Commit();
		}

		void AssignHandler(int resourceId, EventHandler ClickHandler)
		{
			RadioButton button = FindViewById<RadioButton>(resourceId);
			button.Click += ClickHandler;
		}

		void AssignButtonHandlers()
		{
			AssignHandler(Resource.Id.radioButtonHome, HomeButtonClick);
			AssignHandler(Resource.Id.radioButtonTV, TVButtonClick);
			AssignHandler(Resource.Id.radioButtonVideo, VideoButtonClick);
			AssignHandler(Resource.Id.radioButtonRestaurant, RestaurantButtonClick);
			AssignHandler(Resource.Id.radioButtonRoomService, RoomServiceButtonClick);
			AssignHandler(Resource.Id.radioButtonAbout, EntertainmentButtonClick);
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			Window.AddFlags(WindowManagerFlags.Fullscreen);

			SetContentView(Resource.Layout.MainLayout);

			AssignButtonHandlers();

			CreatePageFragments();
		}

		protected override void OnStart()
		{
			base.OnStart();
		}
	}
}

