using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android.Views.Animations;

namespace Bagtyyar
{
	[Activity(Label = "Bagtyýar", 
	          MainLauncher = true, 
	          Icon = "@mipmap/icon", 
	          Theme="@android:style/Theme.Black.NoTitleBar.Fullscreen"
	         )]
	public class SplashActivity : Activity
	{	
		const int SPLASH_ANIMATION_DURATION = 0;
		const int SPLASH_DISAPPEAR_DURATION = 0;
		
		private async void CallLanguagesPage()
		{
			await Task.Delay(SPLASH_DISAPPEAR_DURATION);
			StartActivity(typeof(LanguagesActivity));
			Finish();
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SplashLayout);

			ImageView imageView = FindViewById<ImageView>(Resource.Id.imageViewSplash);


			AlphaAnimation fadeInAnimation = new AlphaAnimation(0, 1)
			{
				Duration = SPLASH_ANIMATION_DURATION
			};

			fadeInAnimation.Interpolator = new LinearInterpolator();

			imageView.Animation = fadeInAnimation;
			imageView.Animate();

			CallLanguagesPage();
		}
	}
}


