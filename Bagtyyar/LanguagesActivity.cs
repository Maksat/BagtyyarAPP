using System;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Method;
using Android.Views;
using Android.Widget;

namespace Bagtyyar
{
	[Activity(Label = "LanguagesActivity", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
	public class LanguagesActivity : Activity, IKeyListener
	{
		Keycode[] passPhrase = { Keycode.DpadUp, Keycode.DpadUp, Keycode.DpadDown, Keycode.DpadDown };
		int curPassIndex;

		Button tmButton, ruButton, enButton;

		public InputTypes InputType
		{
			get
			{
				return InputTypes.Null;
			}
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.LanguagesLayout);

			findViews();
			assignButtonHandlers();
		}

		protected override void OnStart()
		{
			base.OnStart();
			selectLanguageButton();
			curPassIndex = 0;
		}

	 	void CallMainPage()
		{
			StartActivity(typeof(MainActivity));
		}

		void CallAdminPage()
		{
			#warning implement admin page
			StartActivity(typeof(MainActivity));
		}

		bool passPhraseMatches(Keycode key)
		{
			if (curPassIndex < passPhrase.Length)
			{
				if (passPhrase[curPassIndex++] == key)
				{
					if (curPassIndex == passPhrase.Length)
					{
						return true;
					}
				}
				else {
					curPassIndex = 0;
				}

				if (curPassIndex >= passPhrase.Length)
				{
					curPassIndex = 0;
				}
			}
			return false;
		}

		void selectLanguageButton()
		{
			switch (Globals.SelectedLanguage)
			{
				case Language.TM:
					tmButton.RequestFocus();
					break;
				case Language.RU:
					ruButton.RequestFocus();
					break;
				case Language.EN:
					enButton.RequestFocus();
					break;
			}
		}

		void TmPressed(object sender, EventArgs e)
		{
			Globals.SelectedLanguage = Language.TM;
			CallMainPage();
		}

		void RuPressed(object sender, EventArgs e)
		{
			Globals.SelectedLanguage = Language.RU;
			CallMainPage();
		}

		void EnPressed(object sender, EventArgs e)
		{
			Globals.SelectedLanguage = Language.EN;
			CallMainPage();
		}

		void findViews()
		{
			tmButton = FindViewById<Button>(Resource.Id.buttonTM);
			ruButton = FindViewById<Button>(Resource.Id.buttonRU);
			enButton = FindViewById<Button>(Resource.Id.buttonEN);
		}

		void assignButtonHandlers()
		{
			tmButton.Click += TmPressed;
			ruButton.Click += RuPressed;
			enButton.Click += EnPressed;

			tmButton.KeyListener = this;
			ruButton.KeyListener = this;
			enButton.KeyListener = this;
		}

		bool selectNextButton(View view, Keycode key)
		{
			if (view == tmButton && key == Keycode.DpadLeft)
			{
				enButton.RequestFocus();
				AudioManager.FromContext(this).PlaySoundEffect(SoundEffect.NavigationLeft);
				return true;
			}
			else if (view == enButton && key == Keycode.DpadRight)
			{
				tmButton.RequestFocus();
				AudioManager.FromContext(this).PlaySoundEffect(SoundEffect.NavigationRight);
				return true;
			}
			return false;
		}

		//prevents application to close on hardware back button
		public override void OnBackPressed()
		{
			
		}

		public void ClearMetaKeyState(View view, IEditable content, [GeneratedEnum] MetaKeyStates states)
		{
			
		}

		public bool OnKeyDown(View view, IEditable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (keyCode == Keycode.Back)
			{
				return false;
			}

			if (passPhraseMatches(keyCode))
			{
				CallAdminPage();
				return true;
			}
			    
			if (selectNextButton(view, keyCode))
			{
				return true;
			}
			   
			return false;
		}

		public bool OnKeyOther(View view, IEditable text, KeyEvent e)
		{
			return false;
		}

		public bool OnKeyUp(View view, IEditable text, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			return false;
		}
	}
}

