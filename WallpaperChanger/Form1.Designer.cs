namespace WallpaperChanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c_orari = new GroupBox();
            l_mattina = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            minuti_mattina = new NumericUpDown();
            ore_mattina = new NumericUpDown();
            l_sera = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            minuti_sera = new NumericUpDown();
            ore_sera = new NumericUpDown();
            startup = new CheckBox();
            l_cambio = new Label();
            t_cambio = new NumericUpDown();
            c_wallpaper = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            c_buio = new SplitContainer();
            l_buio = new Label();
            choose_buio = new Button();
            t_buio = new TextBox();
            c_w_luce = new SplitContainer();
            l_luce = new Label();
            choose_luce = new Button();
            t_luce = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            groupBox1 = new GroupBox();
            radCasuale = new RadioButton();
            label1 = new Label();
            radSequenziale = new RadioButton();
            c_orari.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minuti_mattina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ore_mattina).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minuti_sera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ore_sera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t_cambio).BeginInit();
            c_wallpaper.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c_buio).BeginInit();
            c_buio.Panel1.SuspendLayout();
            c_buio.Panel2.SuspendLayout();
            c_buio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c_w_luce).BeginInit();
            c_w_luce.Panel1.SuspendLayout();
            c_w_luce.Panel2.SuspendLayout();
            c_w_luce.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // c_orari
            // 
            c_orari.Controls.Add(l_mattina);
            c_orari.Controls.Add(tableLayoutPanel1);
            c_orari.Controls.Add(l_sera);
            c_orari.Controls.Add(tableLayoutPanel2);
            c_orari.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            c_orari.Location = new Point(0, 0);
            c_orari.Name = "c_orari";
            c_orari.Size = new Size(324, 287);
            c_orari.TabIndex = 1;
            c_orari.TabStop = false;
            c_orari.Text = "ORARI";
            c_orari.Resize += Form1_Resize;
            // 
            // l_mattina
            // 
            l_mattina.AutoSize = true;
            l_mattina.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            l_mattina.Location = new Point(6, 52);
            l_mattina.Name = "l_mattina";
            l_mattina.Size = new Size(80, 28);
            l_mattina.TabIndex = 0;
            l_mattina.Text = "Mattina";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(minuti_mattina, 0, 0);
            tableLayoutPanel1.Controls.Add(ore_mattina, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(287, 43);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // minuti_mattina
            // 
            minuti_mattina.BorderStyle = BorderStyle.None;
            minuti_mattina.Dock = DockStyle.Fill;
            minuti_mattina.Font = new Font("Noto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            minuti_mattina.ImeMode = ImeMode.NoControl;
            minuti_mattina.Location = new Point(146, 3);
            minuti_mattina.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuti_mattina.Name = "minuti_mattina";
            minuti_mattina.Size = new Size(138, 35);
            minuti_mattina.TabIndex = 1;
            minuti_mattina.ValueChanged += minuti_mattina_ValueChanged;
            // 
            // ore_mattina
            // 
            ore_mattina.BorderStyle = BorderStyle.None;
            ore_mattina.Dock = DockStyle.Fill;
            ore_mattina.Font = new Font("Noto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ore_mattina.ImeMode = ImeMode.NoControl;
            ore_mattina.Location = new Point(3, 3);
            ore_mattina.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            ore_mattina.Name = "ore_mattina";
            ore_mattina.Size = new Size(137, 35);
            ore_mattina.TabIndex = 0;
            ore_mattina.ValueChanged += ore_mattina_ValueChanged;
            // 
            // l_sera
            // 
            l_sera.AutoSize = true;
            l_sera.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            l_sera.Location = new Point(6, 165);
            l_sera.Name = "l_sera";
            l_sera.Size = new Size(50, 28);
            l_sera.TabIndex = 3;
            l_sera.Text = "Sera";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(minuti_sera, 0, 0);
            tableLayoutPanel2.Controls.Add(ore_sera, 0, 0);
            tableLayoutPanel2.Location = new Point(6, 215);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(287, 43);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // minuti_sera
            // 
            minuti_sera.BorderStyle = BorderStyle.None;
            minuti_sera.Dock = DockStyle.Fill;
            minuti_sera.Font = new Font("Noto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            minuti_sera.ImeMode = ImeMode.NoControl;
            minuti_sera.Location = new Point(146, 3);
            minuti_sera.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuti_sera.Name = "minuti_sera";
            minuti_sera.Size = new Size(138, 35);
            minuti_sera.TabIndex = 1;
            minuti_sera.ValueChanged += minuti_sera_ValueChanged;
            // 
            // ore_sera
            // 
            ore_sera.BorderStyle = BorderStyle.None;
            ore_sera.Dock = DockStyle.Fill;
            ore_sera.Font = new Font("Noto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ore_sera.ImeMode = ImeMode.NoControl;
            ore_sera.Location = new Point(3, 3);
            ore_sera.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            ore_sera.Name = "ore_sera";
            ore_sera.Size = new Size(137, 35);
            ore_sera.TabIndex = 0;
            ore_sera.ValueChanged += ore_sera_ValueChanged;
            // 
            // startup
            // 
            startup.AutoSize = true;
            startup.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            startup.Location = new Point(225, 192);
            startup.Name = "startup";
            startup.Size = new Size(158, 60);
            startup.TabIndex = 7;
            startup.Text = "Start on\r\nsystem startup";
            startup.UseVisualStyleBackColor = true;
            startup.CheckedChanged += startup_CheckedChanged;
            // 
            // l_cambio
            // 
            l_cambio.AutoSize = true;
            l_cambio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            l_cambio.Location = new Point(225, 52);
            l_cambio.Name = "l_cambio";
            l_cambio.Size = new Size(152, 28);
            l_cambio.TabIndex = 6;
            l_cambio.Text = "Minuti Cambio";
            // 
            // t_cambio
            // 
            t_cambio.BorderStyle = BorderStyle.None;
            t_cambio.Font = new Font("Noto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            t_cambio.ImeMode = ImeMode.NoControl;
            t_cambio.Location = new Point(232, 101);
            t_cambio.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            t_cambio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            t_cambio.Name = "t_cambio";
            t_cambio.Size = new Size(138, 35);
            t_cambio.TabIndex = 5;
            t_cambio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            t_cambio.ValueChanged += t_cambio_ValueChanged;
            // 
            // c_wallpaper
            // 
            c_wallpaper.Controls.Add(tableLayoutPanel3);
            c_wallpaper.Dock = DockStyle.Bottom;
            c_wallpaper.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            c_wallpaper.Location = new Point(0, 284);
            c_wallpaper.Name = "c_wallpaper";
            c_wallpaper.Size = new Size(723, 166);
            c_wallpaper.TabIndex = 2;
            c_wallpaper.TabStop = false;
            c_wallpaper.Text = "WALLPAPER";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(c_buio, 0, 0);
            tableLayoutPanel3.Controls.Add(c_w_luce, 0, 0);
            tableLayoutPanel3.Location = new Point(12, 42);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(699, 112);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // c_buio
            // 
            c_buio.Dock = DockStyle.Fill;
            c_buio.Location = new Point(352, 3);
            c_buio.Name = "c_buio";
            c_buio.Orientation = Orientation.Horizontal;
            // 
            // c_buio.Panel1
            // 
            c_buio.Panel1.Controls.Add(l_buio);
            // 
            // c_buio.Panel2
            // 
            c_buio.Panel2.Controls.Add(choose_buio);
            c_buio.Panel2.Controls.Add(t_buio);
            c_buio.Size = new Size(344, 106);
            c_buio.SplitterDistance = 25;
            c_buio.TabIndex = 1;
            // 
            // l_buio
            // 
            l_buio.Dock = DockStyle.Fill;
            l_buio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            l_buio.Location = new Point(0, 0);
            l_buio.Name = "l_buio";
            l_buio.Size = new Size(344, 25);
            l_buio.TabIndex = 0;
            l_buio.Text = "Buio:";
            // 
            // choose_buio
            // 
            choose_buio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            choose_buio.Location = new Point(219, 22);
            choose_buio.Name = "choose_buio";
            choose_buio.Size = new Size(121, 29);
            choose_buio.TabIndex = 1;
            choose_buio.Text = "Choose";
            choose_buio.UseVisualStyleBackColor = true;
            choose_buio.Click += choose_buio_Click;
            // 
            // t_buio
            // 
            t_buio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            t_buio.Location = new Point(17, 22);
            t_buio.Name = "t_buio";
            t_buio.PlaceholderText = "Location";
            t_buio.Size = new Size(196, 29);
            t_buio.TabIndex = 0;
            t_buio.TextChanged += t_buio_TextChanged;
            // 
            // c_w_luce
            // 
            c_w_luce.Dock = DockStyle.Fill;
            c_w_luce.Location = new Point(3, 3);
            c_w_luce.Name = "c_w_luce";
            c_w_luce.Orientation = Orientation.Horizontal;
            // 
            // c_w_luce.Panel1
            // 
            c_w_luce.Panel1.Controls.Add(l_luce);
            // 
            // c_w_luce.Panel2
            // 
            c_w_luce.Panel2.Controls.Add(choose_luce);
            c_w_luce.Panel2.Controls.Add(t_luce);
            c_w_luce.Size = new Size(343, 106);
            c_w_luce.SplitterDistance = 25;
            c_w_luce.TabIndex = 0;
            // 
            // l_luce
            // 
            l_luce.Dock = DockStyle.Fill;
            l_luce.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            l_luce.Location = new Point(0, 0);
            l_luce.Name = "l_luce";
            l_luce.Size = new Size(343, 25);
            l_luce.TabIndex = 0;
            l_luce.Text = "Luce:";
            // 
            // choose_luce
            // 
            choose_luce.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            choose_luce.Location = new Point(219, 22);
            choose_luce.Name = "choose_luce";
            choose_luce.Size = new Size(121, 29);
            choose_luce.TabIndex = 1;
            choose_luce.Text = "Choose";
            choose_luce.UseVisualStyleBackColor = true;
            choose_luce.Click += choose_luce_Click;
            // 
            // t_luce
            // 
            t_luce.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            t_luce.Location = new Point(17, 22);
            t_luce.Name = "t_luce";
            t_luce.PlaceholderText = "Location";
            t_luce.Size = new Size(196, 29);
            t_luce.TabIndex = 0;
            t_luce.TextChanged += t_luce_TextChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Wallpaper Changer";
            notifyIcon1.Click += notifyIcon1_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radCasuale);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radSequenziale);
            groupBox1.Controls.Add(t_cambio);
            groupBox1.Controls.Add(startup);
            groupBox1.Controls.Add(l_cambio);
            groupBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(330, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 287);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPZIONI";
            // 
            // radCasuale
            // 
            radCasuale.AutoSize = true;
            radCasuale.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radCasuale.Location = new Point(34, 154);
            radCasuale.Name = "radCasuale";
            radCasuale.Size = new Size(96, 29);
            radCasuale.TabIndex = 10;
            radCasuale.TabStop = true;
            radCasuale.Text = "Casuale";
            radCasuale.UseVisualStyleBackColor = true;
            radCasuale.Click += ModChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 9;
            label1.Text = "Modalità";
            // 
            // radSequenziale
            // 
            radSequenziale.AutoSize = true;
            radSequenziale.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radSequenziale.Location = new Point(34, 100);
            radSequenziale.Name = "radSequenziale";
            radSequenziale.Size = new Size(132, 29);
            radSequenziale.TabIndex = 8;
            radSequenziale.TabStop = true;
            radSequenziale.Text = "Sequenziale";
            radSequenziale.UseVisualStyleBackColor = true;
            radSequenziale.Click += ModChange;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(groupBox1);
            Controls.Add(c_orari);
            Controls.Add(c_wallpaper);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Wallpaper Changer";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            c_orari.ResumeLayout(false);
            c_orari.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minuti_mattina).EndInit();
            ((System.ComponentModel.ISupportInitialize)ore_mattina).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minuti_sera).EndInit();
            ((System.ComponentModel.ISupportInitialize)ore_sera).EndInit();
            ((System.ComponentModel.ISupportInitialize)t_cambio).EndInit();
            c_wallpaper.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            c_buio.Panel1.ResumeLayout(false);
            c_buio.Panel2.ResumeLayout(false);
            c_buio.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c_buio).EndInit();
            c_buio.ResumeLayout(false);
            c_w_luce.Panel1.ResumeLayout(false);
            c_w_luce.Panel2.ResumeLayout(false);
            c_w_luce.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c_w_luce).EndInit();
            c_w_luce.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox c_orari;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown minuti_sera;
        private NumericUpDown ore_sera;
        private Label l_sera;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown minuti_mattina;
        private NumericUpDown ore_mattina;
        private Label l_mattina;
        private GroupBox c_wallpaper;
        private TableLayoutPanel tableLayoutPanel3;
        private SplitContainer c_w_luce;
        private Label l_luce;
        private TextBox t_luce;
        private Button choose_luce;
        private SplitContainer c_buio;
        private Label l_buio;
        private Button choose_buio;
        private TextBox t_buio;
        private NotifyIcon notifyIcon1;
        private Label l_cambio;
        private NumericUpDown t_cambio;
        private CheckBox startup;
        private GroupBox groupBox1;
        private Label label1;
        private RadioButton radSequenziale;
        private RadioButton radCasuale;
    }
}