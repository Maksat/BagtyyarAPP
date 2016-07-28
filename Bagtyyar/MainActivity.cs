
using Android.App;
using Android.OS;
using Android.Views;


namespace Bagtyyar
{
	[Activity(Label = "")]
	public class MainActivity : Activity, ActionBar.ITabListener
	{

		HomePageFragment homePageFragment;
		TVPageFragment tvPageFragment;
		VidePageFragment videoPageFragment;
		RestaurantPageFragment restaurantPageFragment;
		ServicesPageFragment servicesPageFragment;
		EntertainmentPageFragment entertainmentPageFragment;

		ActionBar.Tab homeTab;
		ActionBar.Tab tvTab;
		ActionBar.Tab videoTab;
		ActionBar.Tab restaurnatTab;
		ActionBar.Tab servicesTab;
		ActionBar.Tab entertainmentTab;


		public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
		{
			
		}

		public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
		{
			if (tab == homeTab)
			{
				if (homePageFragment == null)
				{
					homePageFragment = new HomePageFragment();
					ft.Add(Resource.Id.linearLayout1, homePageFragment);
				}
				else
				{
					ft.Show(homePageFragment);
				}

			}
			else if (tab == tvTab)
			{

				if (tvPageFragment == null)
				{
					tvPageFragment = new TVPageFragment();
					ft.Add(Resource.Id.linearLayout1, tvPageFragment);
				}
				else
				{
					ft.Show(tvPageFragment);
				}
			}
			else if (tab == videoTab)
			{
				if (videoPageFragment == null)
				{
					videoPageFragment = new VidePageFragment();
					ft.Add(Resource.Id.linearLayout1, videoPageFragment);
				}
				else
				{
					ft.Show(videoPageFragment);
				}
			}else if (tab == restaurnatTab)
			{
				if (restaurantPageFragment == null)
				{
					restaurantPageFragment = new RestaurantPageFragment();
					ft.Add(Resource.Id.linearLayout1, restaurantPageFragment);
				}
				else
				{
					ft.Show(restaurantPageFragment);
				}
			}else if (tab == servicesTab)
			{
				if (servicesPageFragment == null)
				{
					servicesPageFragment = new ServicesPageFragment();
					ft.Add(Resource.Id.linearLayout1, servicesPageFragment);
				}
				else
				{
					ft.Show(servicesPageFragment);
				}
			}
			else if (tab == entertainmentTab)
			{
				if (entertainmentPageFragment == null)
				{
					entertainmentPageFragment = new EntertainmentPageFragment();
					ft.Add(Resource.Id.linearLayout1, entertainmentPageFragment);
				}
				else
				{
					ft.Show(entertainmentPageFragment);
				}
			}
		}

		public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
		{
			if (tab == homeTab)
			{
				ft.Hide(homePageFragment);
			}
			else if (tab == tvTab)
			{
				ft.Hide(tvPageFragment);
			}
			else if (tab == videoTab)
			{
				ft.Hide(videoPageFragment);
			}
			else if (tab == restaurnatTab)
			{
				ft.Hide(restaurantPageFragment);
			}
			else if (tab == servicesTab)
			{
				ft.Hide(servicesPageFragment);
			}
			else if (tab == entertainmentTab)
			{
				ft.Hide(entertainmentPageFragment);
			}
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			Window.AddFlags(WindowManagerFlags.Fullscreen);

			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			SetContentView(Resource.Layout.MainLayout);

			homeTab = ActionBar.NewTab();
			homeTab.SetTabListener(this);
			homeTab.SetIcon(Resource.Drawable.EnButton);
			ActionBar.AddTab(homeTab);

			tvTab = ActionBar.NewTab();
			tvTab.SetIcon(Resource.Drawable.RuButton);
			tvTab.SetTabListener(this);
			ActionBar.AddTab(tvTab);

			videoTab = ActionBar.NewTab();
			videoTab.SetIcon(Resource.Drawable.TmButton);
			videoTab.SetTabListener(this);
			ActionBar.AddTab(videoTab);

			restaurnatTab = ActionBar.NewTab();
			restaurnatTab.SetIcon(Resource.Drawable.EnButton);
			restaurnatTab.SetTabListener(this);
			ActionBar.AddTab(restaurnatTab);

			servicesTab = ActionBar.NewTab();
			servicesTab.SetIcon(Resource.Drawable.RuButton);
			servicesTab.SetTabListener(this);
			ActionBar.AddTab(servicesTab);

			entertainmentTab = ActionBar.NewTab();
			entertainmentTab.SetIcon(Resource.Drawable.TmButton);
			entertainmentTab.SetTabListener(this);
			ActionBar.AddTab(entertainmentTab);
		}

		protected override void OnStart()
		{
			base.OnStart();
		}
	}
}

