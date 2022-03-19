using System.Diagnostics;
using System.IO;

namespace WallpaperChanger
{
    static class Constants
    {
        public static string APPLICATION_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\NikiIncFaGiochiDaSchifo\WallpaperChanger\";
        public static string SETTINGS_PATH = APPLICATION_FOLDER + @"settings.settings";
        
    }
    public static class Settings
    {
        static readonly string DEFAULT_CHAR = " ";
        static private string[] _settings = new string[Enum.GetNames(typeof(SettingName)).Length];
        static readonly private string SEPARATOR = ";";
        public static string? GetSetting(SettingName setting)
        {
            return _settings[(int)setting] != DEFAULT_CHAR ? _settings[(int)setting] : null;
        }
        public static int LoadSettings()
        {
            int settingsCount = Enum.GetNames(typeof(SettingName)).Length;
            if (!File.Exists(Constants.SETTINGS_PATH))
            {
                Directory.CreateDirectory(Constants.APPLICATION_FOLDER);
                StreamWriter sw = File.CreateText(Constants.SETTINGS_PATH);
                string[] settingsName = Enum.GetNames(typeof(SettingName));
                for (int i = 0; i < settingsCount; i++)
                {
                    sw.WriteLine(settingsName[i] + SEPARATOR + DEFAULT_CHAR);
                }
                sw.Close();
                return 1;
            }
            StreamReader sr = File.OpenText(Constants.SETTINGS_PATH);
            for(int i = 0; i < settingsCount; i++)
            {
                _settings[i] = sr.ReadLine().Split(SEPARATOR, StringSplitOptions.None)[1];
            }
            sr.Close();
            return 0;
        }
        public enum SettingName : int
        {
            ORE_MATTINA,
            MINUTI_MATTINA,
            ORE_SERA,
            MINUTI_SERA,
            WALLPAPER_LUCE_PATH,
            WALLPAPER_BUIO_PATH
        }
        public static int ChangeSetting(SettingName setting, string value)
        {
            _settings[(int)setting] = value;
            StreamWriter sw = File.CreateText(Constants.SETTINGS_PATH);
            string[] settingsName = Enum.GetNames(typeof(SettingName));
            for(int i = 0; i < _settings.Length; i++)
            {
                sw.WriteLine(settingsName[i] + SEPARATOR + (_settings[i] == null ? " " : _settings[i]));
            }
            sw.Close();
            return 0;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Settings.LoadSettings();
            ApplicationConfiguration.Initialize();
            LogicaWallpaper.Start();
            Application.Run(new Form1());
        }
    }
}