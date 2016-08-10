using System;
using System.IO;


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
		static Language selectedLanguage;
		static string settingsPath = "settings.xml"; 

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

		public static string SettingsPath
		{
			get
			{
				var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				var filePath = Path.Combine(documentsPath, settingsPath);
				return filePath;
			}
		}
	}
}

