using System.IO;

namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ore_mattina.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.ORE_MATTINA) ?? "0");
            minuti_mattina.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.MINUTI_MATTINA) ?? "0");
            ore_sera.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.ORE_SERA) ?? "0");
            minuti_sera.Value = Convert.ToDecimal(Settings.GetSetting(Settings.SettingName.MINUTI_SERA) ?? "0");
            t_luce.Text = Settings.GetSetting(Settings.SettingName.WALLPAPER_LUCE_PATH) ?? "";
            t_buio.Text = Settings.GetSetting(Settings.SettingName.WALLPAPER_BUIO_PATH) ?? "";
        }
        public decimal CheckMax(decimal num, decimal max)
        {
            return num > max ? max : num;
        }
        public Form1()
        {
            InitializeComponent();
        }

        // ---- MINUTI E ORE SERA ----
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
            Settings.ChangeSetting(Settings.SettingName.MINUTI_SERA, Convert.ToString(CheckMax(minuti_sera.Value, 23)));
        }

        // ---- DIRECTORY WALLPAPER ----

        private void choose_luce_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if(result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
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
                    t_luce.Text = fbd.SelectedPath;
                    Settings.ChangeSetting(Settings.SettingName.WALLPAPER_LUCE_PATH, fbd.SelectedPath);
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
    }
}