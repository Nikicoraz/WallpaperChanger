using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace WallpaperChanger
{
    internal class LogicaWallpaper
    {
        public static bool exit = false;
        static DateTime? ultimoCambiamento = DateTime.Now;
        static int precedente = 0;
        public enum Modo
        {
            light,
            dark
        }

        public enum Modalita : int
        {
            SEQUENZIALE,
            CASUALE
        }
        public static void CambiaDesktop(Modo modo, bool forced = false)
        {
            if(!forced && DateTime.Now - ultimoCambiamento < TimeSpan.FromMinutes(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.TEMPO_CAMBIO))) || 
                Settings.GetSetting(modo == Modo.light ? Settings.SettingName.WALLPAPER_LUCE_PATH : Settings.SettingName.WALLPAPER_BUIO_PATH) == null)
            {
                return;
            }
            string path = Settings.GetSetting(modo == Modo.light ? Settings.SettingName.WALLPAPER_LUCE_PATH : Settings.SettingName.WALLPAPER_BUIO_PATH) ?? "";
            if (!String.IsNullOrEmpty(path))
            {
                string[] files = Directory.EnumerateFiles(path, "*.*").Where(file => file.ToLower().EndsWith("png") || file.ToLower().EndsWith("jpg"))
                    .ToArray();
                if((Modalita)Convert.ToInt16(Settings.GetSetting(Settings.SettingName.MODALITA)) == Modalita.SEQUENZIALE)
                {
                    WallpaperManager.Set(files[precedente++ % files.Length], WallpaperManager.Style.Fill);
                }
                else
                {
                    Random r = new();
                    int num;
                    while ((num = r.Next(0, files.Length)) == precedente) ;
                    WallpaperManager.Set(files[num], WallpaperManager.Style.Fill);
                }
            }
            ultimoCambiamento = DateTime.Now;
        }
        public static void Start()
        {
            Debug.WriteLine("Partito");
            new Thread(() =>
            {
                while (!exit)
                {
                    DateTime now = DateTime.Now;
                    DateTime light = DateTime.Today;
                    DateTime dark = DateTime.Today;
                    dark = dark.AddHours(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.ORE_SERA)));
                    dark = dark.AddMinutes(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.MINUTI_SERA)));
                    light = light.AddHours(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.ORE_MATTINA)));
                    light  = light.AddMinutes(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.MINUTI_MATTINA)));
                    // Dark
                    if (now > dark || now < light)
                    {
                        CambiaDesktop(Modo.dark);
                    }
                    // Light
                    else
                    {
                        CambiaDesktop(Modo.light);
                    }
                    Thread.Sleep(2000);
                }
            }).Start();
        }
    }
}
