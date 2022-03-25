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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c_orari = new System.Windows.Forms.GroupBox();
            this.l_cambio = new System.Windows.Forms.Label();
            this.t_cambio = new System.Windows.Forms.NumericUpDown();
            this.l_mattina = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.minuti_mattina = new System.Windows.Forms.NumericUpDown();
            this.ore_mattina = new System.Windows.Forms.NumericUpDown();
            this.l_sera = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.minuti_sera = new System.Windows.Forms.NumericUpDown();
            this.ore_sera = new System.Windows.Forms.NumericUpDown();
            this.c_wallpaper = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.c_buio = new System.Windows.Forms.SplitContainer();
            this.l_buio = new System.Windows.Forms.Label();
            this.choose_buio = new System.Windows.Forms.Button();
            this.t_buio = new System.Windows.Forms.TextBox();
            this.c_w_luce = new System.Windows.Forms.SplitContainer();
            this.l_luce = new System.Windows.Forms.Label();
            this.choose_luce = new System.Windows.Forms.Button();
            this.t_luce = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.c_orari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_cambio)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuti_mattina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ore_mattina)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuti_sera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ore_sera)).BeginInit();
            this.c_wallpaper.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_buio)).BeginInit();
            this.c_buio.Panel1.SuspendLayout();
            this.c_buio.Panel2.SuspendLayout();
            this.c_buio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_w_luce)).BeginInit();
            this.c_w_luce.Panel1.SuspendLayout();
            this.c_w_luce.Panel2.SuspendLayout();
            this.c_w_luce.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_orari
            // 
            this.c_orari.Controls.Add(this.l_cambio);
            this.c_orari.Controls.Add(this.t_cambio);
            this.c_orari.Controls.Add(this.l_mattina);
            this.c_orari.Controls.Add(this.tableLayoutPanel1);
            this.c_orari.Controls.Add(this.l_sera);
            this.c_orari.Controls.Add(this.tableLayoutPanel2);
            this.c_orari.Dock = System.Windows.Forms.DockStyle.Top;
            this.c_orari.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_orari.Location = new System.Drawing.Point(0, 0);
            this.c_orari.Name = "c_orari";
            this.c_orari.Size = new System.Drawing.Size(723, 287);
            this.c_orari.TabIndex = 1;
            this.c_orari.TabStop = false;
            this.c_orari.Text = "ORARI";
            this.c_orari.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // l_cambio
            // 
            this.l_cambio.AutoSize = true;
            this.l_cambio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_cambio.Location = new System.Drawing.Point(526, 116);
            this.l_cambio.Name = "l_cambio";
            this.l_cambio.Size = new System.Drawing.Size(142, 28);
            this.l_cambio.TabIndex = 6;
            this.l_cambio.Text = "Minuti Cambio";
            // 
            // t_cambio
            // 
            this.t_cambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_cambio.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.t_cambio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t_cambio.Location = new System.Drawing.Point(526, 165);
            this.t_cambio.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.t_cambio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t_cambio.Name = "t_cambio";
            this.t_cambio.Size = new System.Drawing.Size(138, 35);
            this.t_cambio.TabIndex = 5;
            this.t_cambio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t_cambio.ValueChanged += new System.EventHandler(this.t_cambio_ValueChanged);
            // 
            // l_mattina
            // 
            this.l_mattina.AutoSize = true;
            this.l_mattina.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_mattina.Location = new System.Drawing.Point(6, 52);
            this.l_mattina.Name = "l_mattina";
            this.l_mattina.Size = new System.Drawing.Size(80, 28);
            this.l_mattina.TabIndex = 0;
            this.l_mattina.Text = "Mattina";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.minuti_mattina, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ore_mattina, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // minuti_mattina
            // 
            this.minuti_mattina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuti_mattina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minuti_mattina.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minuti_mattina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minuti_mattina.Location = new System.Drawing.Point(146, 3);
            this.minuti_mattina.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuti_mattina.Name = "minuti_mattina";
            this.minuti_mattina.Size = new System.Drawing.Size(138, 35);
            this.minuti_mattina.TabIndex = 1;
            this.minuti_mattina.ValueChanged += new System.EventHandler(this.minuti_mattina_ValueChanged);
            // 
            // ore_mattina
            // 
            this.ore_mattina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ore_mattina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ore_mattina.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ore_mattina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ore_mattina.Location = new System.Drawing.Point(3, 3);
            this.ore_mattina.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ore_mattina.Name = "ore_mattina";
            this.ore_mattina.Size = new System.Drawing.Size(137, 35);
            this.ore_mattina.TabIndex = 0;
            this.ore_mattina.ValueChanged += new System.EventHandler(this.ore_mattina_ValueChanged);
            // 
            // l_sera
            // 
            this.l_sera.AutoSize = true;
            this.l_sera.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_sera.Location = new System.Drawing.Point(6, 165);
            this.l_sera.Name = "l_sera";
            this.l_sera.Size = new System.Drawing.Size(50, 28);
            this.l_sera.TabIndex = 3;
            this.l_sera.Text = "Sera";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.minuti_sera, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ore_sera, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 215);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 43);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // minuti_sera
            // 
            this.minuti_sera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuti_sera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minuti_sera.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minuti_sera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minuti_sera.Location = new System.Drawing.Point(146, 3);
            this.minuti_sera.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuti_sera.Name = "minuti_sera";
            this.minuti_sera.Size = new System.Drawing.Size(138, 35);
            this.minuti_sera.TabIndex = 1;
            this.minuti_sera.ValueChanged += new System.EventHandler(this.minuti_sera_ValueChanged);
            // 
            // ore_sera
            // 
            this.ore_sera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ore_sera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ore_sera.Font = new System.Drawing.Font("Noto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ore_sera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ore_sera.Location = new System.Drawing.Point(3, 3);
            this.ore_sera.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.ore_sera.Name = "ore_sera";
            this.ore_sera.Size = new System.Drawing.Size(137, 35);
            this.ore_sera.TabIndex = 0;
            this.ore_sera.ValueChanged += new System.EventHandler(this.ore_sera_ValueChanged);
            // 
            // c_wallpaper
            // 
            this.c_wallpaper.Controls.Add(this.tableLayoutPanel3);
            this.c_wallpaper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_wallpaper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_wallpaper.Location = new System.Drawing.Point(0, 284);
            this.c_wallpaper.Name = "c_wallpaper";
            this.c_wallpaper.Size = new System.Drawing.Size(723, 166);
            this.c_wallpaper.TabIndex = 2;
            this.c_wallpaper.TabStop = false;
            this.c_wallpaper.Text = "WALLPAPER";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.c_buio, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.c_w_luce, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(699, 112);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // c_buio
            // 
            this.c_buio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_buio.Location = new System.Drawing.Point(352, 3);
            this.c_buio.Name = "c_buio";
            this.c_buio.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // c_buio.Panel1
            // 
            this.c_buio.Panel1.Controls.Add(this.l_buio);
            // 
            // c_buio.Panel2
            // 
            this.c_buio.Panel2.Controls.Add(this.choose_buio);
            this.c_buio.Panel2.Controls.Add(this.t_buio);
            this.c_buio.Size = new System.Drawing.Size(344, 106);
            this.c_buio.SplitterDistance = 25;
            this.c_buio.TabIndex = 1;
            // 
            // l_buio
            // 
            this.l_buio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_buio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_buio.Location = new System.Drawing.Point(0, 0);
            this.l_buio.Name = "l_buio";
            this.l_buio.Size = new System.Drawing.Size(344, 25);
            this.l_buio.TabIndex = 0;
            this.l_buio.Text = "Buio:";
            // 
            // choose_buio
            // 
            this.choose_buio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choose_buio.Location = new System.Drawing.Point(219, 22);
            this.choose_buio.Name = "choose_buio";
            this.choose_buio.Size = new System.Drawing.Size(121, 29);
            this.choose_buio.TabIndex = 1;
            this.choose_buio.Text = "Choose";
            this.choose_buio.UseVisualStyleBackColor = true;
            this.choose_buio.Click += new System.EventHandler(this.choose_buio_Click);
            // 
            // t_buio
            // 
            this.t_buio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_buio.Location = new System.Drawing.Point(17, 22);
            this.t_buio.Name = "t_buio";
            this.t_buio.PlaceholderText = "Location";
            this.t_buio.Size = new System.Drawing.Size(196, 29);
            this.t_buio.TabIndex = 0;
            this.t_buio.TextChanged += new System.EventHandler(this.t_buio_TextChanged);
            // 
            // c_w_luce
            // 
            this.c_w_luce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_w_luce.Location = new System.Drawing.Point(3, 3);
            this.c_w_luce.Name = "c_w_luce";
            this.c_w_luce.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // c_w_luce.Panel1
            // 
            this.c_w_luce.Panel1.Controls.Add(this.l_luce);
            // 
            // c_w_luce.Panel2
            // 
            this.c_w_luce.Panel2.Controls.Add(this.choose_luce);
            this.c_w_luce.Panel2.Controls.Add(this.t_luce);
            this.c_w_luce.Size = new System.Drawing.Size(343, 106);
            this.c_w_luce.SplitterDistance = 25;
            this.c_w_luce.TabIndex = 0;
            // 
            // l_luce
            // 
            this.l_luce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_luce.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_luce.Location = new System.Drawing.Point(0, 0);
            this.l_luce.Name = "l_luce";
            this.l_luce.Size = new System.Drawing.Size(343, 25);
            this.l_luce.TabIndex = 0;
            this.l_luce.Text = "Luce:";
            // 
            // choose_luce
            // 
            this.choose_luce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choose_luce.Location = new System.Drawing.Point(219, 22);
            this.choose_luce.Name = "choose_luce";
            this.choose_luce.Size = new System.Drawing.Size(121, 29);
            this.choose_luce.TabIndex = 1;
            this.choose_luce.Text = "Choose";
            this.choose_luce.UseVisualStyleBackColor = true;
            this.choose_luce.Click += new System.EventHandler(this.choose_luce_Click);
            // 
            // t_luce
            // 
            this.t_luce.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.t_luce.Location = new System.Drawing.Point(17, 22);
            this.t_luce.Name = "t_luce";
            this.t_luce.PlaceholderText = "Location";
            this.t_luce.Size = new System.Drawing.Size(196, 29);
            this.t_luce.TabIndex = 0;
            this.t_luce.TextChanged += new System.EventHandler(this.t_luce_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Wallpaper Changer";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.c_orari);
            this.Controls.Add(this.c_wallpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wallpaper Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.c_orari.ResumeLayout(false);
            this.c_orari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_cambio)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minuti_mattina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ore_mattina)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minuti_sera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ore_sera)).EndInit();
            this.c_wallpaper.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.c_buio.Panel1.ResumeLayout(false);
            this.c_buio.Panel2.ResumeLayout(false);
            this.c_buio.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_buio)).EndInit();
            this.c_buio.ResumeLayout(false);
            this.c_w_luce.Panel1.ResumeLayout(false);
            this.c_w_luce.Panel2.ResumeLayout(false);
            this.c_w_luce.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_w_luce)).EndInit();
            this.c_w_luce.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}