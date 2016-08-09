using System;
using System.IO;
using System.Xml.Serialization;

namespace Bagtyyar
{
	public class Settings
	{
		static Settings currentSettings;

		string servicePath = "";
		string defaultRoomId = "";
		string videosPath = "";
		string tvPlaylistPath = "";
		string imagesPath = "";
		string stringsPath = "";

		public Settings()
		{
		}

		public static Settings CurrentSettings
		{
			get
			{
				if (currentSettings == null)
				{

					currentSettings = deserializeSettings();

					if (currentSettings == null)
					{
						currentSettings = new Settings();
					}
				}
				return currentSettings;
			}
		}

		public void ClearSettings()
		{
			if (!File.Exists(Globals.SettingsPath))
			{
				return;
			}

			try
			{
				File.Delete(Globals.SettingsPath);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			currentSettings = null;

		}

		static Settings deserializeSettings()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Settings));//initialises the serialiser
			Settings deserializedSettings = null;

			if (!File.Exists(Globals.SettingsPath))
			{
				return null;
			}

			try
			{
				Stream reader = new FileStream(Globals.SettingsPath, FileMode.Open); //Initialises the reader
			
				deserializedSettings = (Settings)serializer.Deserialize(reader); //reads from the xml file and inserts it in this variable
				reader.Close(); //closes the reader
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				return null;	
			}

			return deserializedSettings;
		}

		void serializeSettings()
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(Settings));//initialises the serialiser
				Stream writer = new FileStream(Globals.SettingsPath, FileMode.OpenOrCreate, FileAccess.Write); //Initialises the reader
				serializer.Serialize(writer, currentSettings);
				writer.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}

		public string ServicePath
		{
			get
			{
				return servicePath;
			}

			set
			{
				servicePath = value;
				serializeSettings();
			}
		}

		public string DefaultRoomId
		{
			get
			{
				return defaultRoomId;
			}

			set
			{
				defaultRoomId = value;
				serializeSettings();
			}
		}

		public string VideosPath
		{
			get
			{
				return videosPath;
			}

			set
			{
				videosPath = value;
				serializeSettings();
			}
		}

		public string TvPlaylistPath
		{
			get
			{
				return tvPlaylistPath;
			}

			set
			{
				tvPlaylistPath = value;
				serializeSettings();
			}
		}

		public string ImagesPath
		{
			get
			{
				return imagesPath;
			}

			set
			{
				imagesPath = value;
				serializeSettings();
			}
		}

		public string StringsPath
		{
			get
			{
				return stringsPath;
			}

			set
			{
				stringsPath = value;
				serializeSettings();
			}
		}
	}
}

