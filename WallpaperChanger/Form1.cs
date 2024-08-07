using System.IO;
using Microsoft.Win32;

namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        public decimal CheckMax(decimal num, decimal max)
        {
            return num > max ? max : num;
        }
        public Form1()
        {
            InitializeComponent();
        }

        //
        // ---- MINUTI E ORE SERA ----
        //

        private void ore_mattina_ValueChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.ORE_MATTINA, Convert.ToString(CheckMax(ore_mattina.Value, 23)));
        }
        private void minuti_mattina_ValueChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.MINUTI_MATTINA, Convert.ToString(CheckMax(minuti_mattina.Value, 59)));
        }
        private void ore_sera_ValueChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.ORE_SERA, Convert.ToString(CheckMax(ore_sera.Value, 23)));
        }

        private void minuti_sera_ValueChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.MINUTI_SERA, Convert.ToString(CheckMax(minuti_sera.Value, 59)));
        }

        //
        // ---- DIRECTORY WALLPAPER ----
        //

        private void choose_luce_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    t_luce.Text = fbd.SelectedPath;
                    Settings.ChangeSetting(Settings.SettingName.WALLPAPER_LUCE_PATH, fbd.SelectedPath);
                }
            }
        }

        private void choose_buio_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    t_buio.Text = fbd.SelectedPath;
                    Settings.ChangeSetting(Settings.SettingName.WALLPAPER_BUIO_PATH, fbd.SelectedPath);
                }
            }
        }

        private void t_luce_TextChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.WALLPAPER_LUCE_PATH, t_luce.Text);
        }

        private void t_buio_TextChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.WALLPAPER_BUIO_PATH, t_buio.Text);
        }
        private void t_cambio_ValueChanged(object sender, EventArgs e)
        {
            Settings.ChangeSetting(Settings.SettingName.TEMPO_CAMBIO, t_cambio.Value.ToString());
        }

        //
        // ---- AZIONI FORM ----
        //

        private void Form1_Load(object sender, EventArgs e)
        {
            ore_mattina.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.ORE_MATTINA) ?? "0");
            minuti_mattina.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.MINUTI_MATTINA) ?? "0");
            ore_sera.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.ORE_SERA) ?? "0");
            minuti_sera.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.MINUTI_SERA) ?? "0");
            t_luce.Text = Settings.GetSetting(Settings.SettingName.WALLPAPER_LUCE_PATH) ?? "";
            t_buio.Text = Settings.GetSetting(Settings.SettingName.WALLPAPER_BUIO_PATH) ?? "";
            t_cambio.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.TEMPO_CAMBIO) ?? "10");
            startup.Checked = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false)
                .GetValue(Constants.APPLICATION_NAME) != null ? true : false;
            radSequenziale.Checked = (LogicaWallpaper.Modalita)Convert.ToInt16(Settings.GetSetting(Settings.SettingName.MODALITA) ?? "0") == LogicaWallpaper.Modalita.SEQUENZIALE;
            radCasuale.Checked = (LogicaWallpaper.Modalita)Convert.ToInt16(Settings.GetSetting(Settings.SettingName.MODALITA) ?? "0") == LogicaWallpaper.Modalita.CASUALE;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogicaWallpaper.exit = true;
        }
        private void notifyIcon1_MouseClick(object sender, EventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        //
        // ---- AUTO STARTUP ----
        //

        private void startup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startup.Checked)
            {
                rk.SetValue(Constants.APPLICATION_NAME, Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue(Constants.APPLICATION_NAME);
            }
        }

        //
        // ---- MODALITA' ----
        //

        private void ModChange(object sender, EventArgs e)
        {
            if (radSequenziale.Checked)
            {
                Settings.ChangeSetting(Settings.SettingName.MODALITA, Convert.ToInt16(LogicaWallpaper.Modalita.SEQUENZIALE).ToString());
            }
            else
            {
                Settings.ChangeSetting(Settings.SettingName.MODALITA, Convert.ToInt16(LogicaWallpaper.Modalita.CASUALE).ToString());
            }
        }

        private void cambiaSfondo_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime light = DateTime.Today;
            DateTime dark = DateTime.Today;
            dark = dark.AddHours(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.ORE_SERA)));
            dark = dark.AddMinutes(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.MINUTI_SERA)));
            light = light.AddHours(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.ORE_MATTINA)));
            light = light.AddMinutes(Convert.ToInt32(Settings.GetSetting(Settings.SettingName.MINUTI_MATTINA)));
            // Dark
            if (now > dark || now < light)
            {
                LogicaWallpaper.CambiaDesktop(LogicaWallpaper.Modo.dark, true);
            }
            // Light
            else
            {
                LogicaWallpaper.CambiaDesktop(LogicaWallpaper.Modo.light, true);
            }
        }
    }
}