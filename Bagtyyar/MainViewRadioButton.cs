using Android.Widget;
using Android.Media;

namespace Bagtyyar
{
	public class MainViewRadioButton: RadioButton
	{

		public override bool CallOnClick()
		{
			AudioManager.FromContext(this).PlaySoundEffect(SoundEffect.NavigationLeft);
			return base.CallOnClick();
		}
		//public MainViewRadioButton()
		//{
		//	AudioManager.FromContext(this).PlaySoundEffect(SoundEffect.NavigationLeft);
		//}
	}
}

