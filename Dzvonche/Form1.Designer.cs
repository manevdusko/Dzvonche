namespace Dzvonche
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raspored = new System.Windows.Forms.Label();
            this.vreme = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.povrzi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smena = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kedzvone = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.normal = new System.Windows.Forms.RadioButton();
            this.min5 = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.kolku = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.soff = new System.Windows.Forms.Button();
            this.sl = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.settings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // raspored
            // 
            this.raspored.AutoSize = true;
            this.raspored.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.raspored.ForeColor = System.Drawing.Color.DarkGreen;
            this.raspored.Location = new System.Drawing.Point(264, 9);
            this.raspored.Name = "raspored";
            this.raspored.Size = new System.Drawing.Size(258, 69);
            this.raspored.TabIndex = 3;
            this.raspored.Text = "Прв Час";
            this.raspored.Click += new System.EventHandler(this.raspored_Click);
            // 
            // vreme
            // 
            this.vreme.AutoSize = true;
            this.vreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.vreme.ForeColor = System.Drawing.Color.Red;
            this.vreme.Location = new System.Drawing.Point(0, -1);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(386, 76);
            this.vreme.TabIndex = 4;
            this.vreme.Text = "15:15:03.00";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.datum.ForeColor = System.Drawing.Color.OliveDrab;
            this.datum.Location = new System.Drawing.Point(2, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(279, 63);
            this.datum.TabIndex = 5;
            this.datum.Text = "15-Dec-19";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // povrzi
            // 
            this.povrzi.BackColor = System.Drawing.Color.NavajoWhite;
            this.povrzi.Location = new System.Drawing.Point(68, 617);
            this.povrzi.Name = "povrzi";
            this.povrzi.Size = new System.Drawing.Size(75, 23);
            this.povrzi.TabIndex = 10;
            this.povrzi.Text = "Поврзи";
            this.povrzi.UseVisualStyleBackColor = false;
            this.povrzi.Visible = false;
            this.povrzi.Click += new System.EventHandler(this.povrzi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 617);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.NavajoWhite;
            this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(1057, 626);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(275, 91);
            this.lb.TabIndex = 12;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.NavajoWhite;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(93, 694);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(111, 23);
            this.add.TabIndex = 13;
            this.add.Text = "Додај во плејлиста";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.smena);
            this.panel1.Controls.Add(this.raspored);
            this.panel1.Location = new System.Drawing.Point(155, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 88);
            this.panel1.TabIndex = 17;
            // 
            // smena
            // 
            this.smena.AutoSize = true;
            this.smena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.smena.ForeColor = System.Drawing.Color.OliveDrab;
            this.smena.Location = new System.Drawing.Point(10, 49);
            this.smena.Name = "smena";
            this.smena.Size = new System.Drawing.Size(146, 29);
            this.smena.TabIndex = 4;
            this.smena.Text = "прва смена";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.vreme);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 75);
            this.panel2.TabIndex = 18;
            // 
            // kedzvone
            // 
            this.kedzvone.AutoSize = true;
            this.kedzvone.BackColor = System.Drawing.Color.Transparent;
            this.kedzvone.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.kedzvone.ForeColor = System.Drawing.Color.Red;
            this.kedzvone.Location = new System.Drawing.Point(3, 0);
            this.kedzvone.Name = "kedzvone";
            this.kedzvone.Size = new System.Drawing.Size(386, 76);
            this.kedzvone.TabIndex = 4;
            this.kedzvone.Text = "00:03:03.00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.BackColor = System.Drawing.Color.NavajoWhite;
            this.normal.Location = new System.Drawing.Point(389, 700);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(130, 17);
            this.normal.TabIndex = 20;
            this.normal.TabStop = true;
            this.normal.Text = "Нормални часови     ";
            this.normal.UseVisualStyleBackColor = false;
            this.normal.Visible = false;
            this.normal.CheckedChanged += new System.EventHandler(this.normal_CheckedChanged);
            // 
            // min5
            // 
            this.min5.AutoSize = true;
            this.min5.BackColor = System.Drawing.Color.NavajoWhite;
            this.min5.Location = new System.Drawing.Point(13, 648);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(130, 17);
            this.min5.TabIndex = 21;
            this.min5.TabStop = true;
            this.min5.Text = "Скратени 5 минути   ";
            this.min5.UseVisualStyleBackColor = false;
            this.min5.Visible = false;
            this.min5.CheckedChanged += new System.EventHandler(this.min5_CheckedChanged);
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.BackColor = System.Drawing.Color.NavajoWhite;
            this.other.Location = new System.Drawing.Point(13, 671);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(73, 17);
            this.other.TabIndex = 22;
            this.other.TabStop = true;
            this.other.Text = "Скратени";
            this.other.UseVisualStyleBackColor = false;
            this.other.Visible = false;
            this.other.CheckedChanged += new System.EventHandler(this.other_CheckedChanged);
            // 
            // kolku
            // 
            this.kolku.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kolku.Location = new System.Drawing.Point(92, 670);
            this.kolku.Name = "kolku";
            this.kolku.Size = new System.Drawing.Size(51, 20);
            this.kolku.TabIndex = 23;
            this.kolku.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Dzvonche1.Properties.Resources.ljupcoSantov;
            this.pictureBox1.Location = new System.Drawing.Point(404, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 262);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Linen;
            this.panel5.Controls.Add(this.kedzvone);
            this.panel5.Location = new System.Drawing.Point(710, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 75);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.Controls.Add(this.datum);
            this.panel6.Location = new System.Drawing.Point(12, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 75);
            this.panel6.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "ресет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(155, 596);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(138, 23);
            this.s.TabIndex = 26;
            this.s.Text = "Покажи соопштение";
            this.s.UseVisualStyleBackColor = true;
            this.s.Visible = false;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // soff
            // 
            this.soff.Location = new System.Drawing.Point(155, 625);
            this.soff.Name = "soff";
            this.soff.Size = new System.Drawing.Size(138, 23);
            this.soff.TabIndex = 27;
            this.soff.Text = "Тргни го соопштението";
            this.soff.UseVisualStyleBackColor = true;
            this.soff.Visible = false;
            this.soff.Click += new System.EventHandler(this.soff_Click);
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl.Location = new System.Drawing.Point(311, 439);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(425, 76);
            this.sl.TabIndex = 28;
            this.sl.Text = "Соопштение";
            this.sl.Visible = false;
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(155, 654);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(138, 20);
            this.e1.TabIndex = 29;
            this.e1.Tag = "";
            this.e1.Text = "внеси соопштение";
            this.e1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(218, 694);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 30;
            this.settings.Text = "Опции";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 594);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Ѕвони во сабота";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(299, 133);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(381, 250);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dzvonche1.Properties.Resources.ls;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.soff);
            this.Controls.Add(this.s);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kolku);
            this.Controls.Add(this.other);
            this.Controls.Add(this.min5);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.povrzi);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "m@nev Училишно Ѕвонче";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label raspored;
        private System.Windows.Forms.Label vreme;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button povrzi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label kedzvone;
        private System.Windows.Forms.Label smena;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton min5;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.TextBox kolku;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button soff;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.TextBox e1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

