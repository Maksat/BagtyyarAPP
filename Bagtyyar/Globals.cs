using System;
namespace Bagtyyar
{
	public enum Language
	{
		TM,
		RU,
		EN
	}

	public static class Globals
	{
		private static Language selectedLanguage;

		public static Language SelectedLanguage
		{
			get
			{
				return selectedLanguage;
			}

			set
			{
				selectedLanguage = value;
			}
		}
	}
}

