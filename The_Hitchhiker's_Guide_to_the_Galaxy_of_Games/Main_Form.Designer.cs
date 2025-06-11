namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.rules_box = new System.Windows.Forms.TextBox();
            this.little_combo_box = new System.Windows.Forms.ComboBox();
            this.middle_combo_box = new System.Windows.Forms.ComboBox();
            this.senior_combo_box = new System.Windows.Forms.ComboBox();
            this.label_mem = new System.Windows.Forms.Label();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_click_on_me = new System.Windows.Forms.Label();
            this.candle_picture_box = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candle_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // rules_box
            // 
            this.rules_box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rules_box.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_box.Location = new System.Drawing.Point(397, 31);
            this.rules_box.Multiline = true;
            this.rules_box.Name = "rules_box";
            this.rules_box.ReadOnly = true;
            this.rules_box.Size = new System.Drawing.Size(332, 200);
            this.rules_box.TabIndex = 1;
            this.rules_box.Text = resources.GetString("rules_box.Text");
            // 
            // little_combo_box
            // 
            this.little_combo_box.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.little_combo_box.FormattingEnabled = true;
            this.little_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.little_combo_box.Location = new System.Drawing.Point(509, 237);
            this.little_combo_box.Name = "little_combo_box";
            this.little_combo_box.Size = new System.Drawing.Size(220, 31);
            this.little_combo_box.TabIndex = 5;
            this.little_combo_box.Text = "МЛАДШИИИИЕ";
            this.little_combo_box.SelectedIndexChanged += new System.EventHandler(this.little_combo_box_selected_item);
            // 
            // middle_combo_box
            // 
            this.middle_combo_box.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_combo_box.FormattingEnabled = true;
            this.middle_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.middle_combo_box.Location = new System.Drawing.Point(509, 273);
            this.middle_combo_box.Name = "middle_combo_box";
            this.middle_combo_box.Size = new System.Drawing.Size(220, 31);
            this.middle_combo_box.TabIndex = 6;
            this.middle_combo_box.Text = "СРЕДНИЕ";
            this.middle_combo_box.SelectedIndexChanged += new System.EventHandler(this.middle_combo_box_selected_item);
            // 
            // senior_combo_box
            // 
            this.senior_combo_box.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.senior_combo_box.FormattingEnabled = true;
            this.senior_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.senior_combo_box.Location = new System.Drawing.Point(508, 309);
            this.senior_combo_box.Name = "senior_combo_box";
            this.senior_combo_box.Size = new System.Drawing.Size(220, 31);
            this.senior_combo_box.TabIndex = 7;
            this.senior_combo_box.Text = "СТАРШИЕ";
            this.senior_combo_box.SelectedIndexChanged += new System.EventHandler(this.senior_combo_box_selected_item);
            // 
            // label_mem
            // 
            this.label_mem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mem.Location = new System.Drawing.Point(8, 218);
            this.label_mem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mem.Name = "label_mem";
            this.label_mem.Size = new System.Drawing.Size(150, 37);
            this.label_mem.TabIndex = 9;
            this.label_mem.Text = "Это твоя аватарка кстати =)))";
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(176, 147);
            this.progress_bar.Margin = new System.Windows.Forms.Padding(2);
            this.progress_bar.Maximum = 63;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(180, 25);
            this.progress_bar.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.создателиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.show_what_is_this_about);
            // 
            // создателиToolStripMenuItem
            // 
            this.создателиToolStripMenuItem.Name = "создателиToolStripMenuItem";
            this.создателиToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.создателиToolStripMenuItem.Text = "Создатели";
            this.создателиToolStripMenuItem.Click += new System.EventHandler(this.creators);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "Эта полоска снизу будет отображать твой прогресс как вожатого @";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Firebrick;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.ForeColor = System.Drawing.Color.Snow;
            this.button.Location = new System.Drawing.Point(628, 417);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 30);
            this.button.TabIndex = 14;
            this.button.Text = "ПОДДЕРЖКА";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.help);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 30);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 30);
            this.label.TabIndex = 15;
            this.label.Text = "v0zhatyi_2005";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_click_on_me
            // 
            this.label_click_on_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_click_on_me.Location = new System.Drawing.Point(11, 310);
            this.label_click_on_me.Name = "label_click_on_me";
            this.label_click_on_me.Size = new System.Drawing.Size(110, 23);
            this.label_click_on_me.TabIndex = 16;
            this.label_click_on_me.Text = "Click on me!";
            this.label_click_on_me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_click_on_me, "на свечку надо нажать ...");
            // 
            // candle_picture_box
            // 
            this.candle_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.candle_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.candle_picture_box.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle_b_2;
            this.candle_picture_box.Location = new System.Drawing.Point(11, 337);
            this.candle_picture_box.Margin = new System.Windows.Forms.Padding(2);
            this.candle_picture_box.Name = "candle_picture_box";
            this.candle_picture_box.Size = new System.Drawing.Size(110, 110);
            this.candle_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candle_picture_box.TabIndex = 8;
            this.candle_picture_box.TabStop = false;
            this.candle_picture_box.Click += new System.EventHandler(this.picture_box_Click);
            // 
            // avatar
            // 
            this.avatar.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.avatar_image1;
            this.avatar.Location = new System.Drawing.Point(8, 66);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(150, 140);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.main_form_background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(736, 469);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 12;
            this.background.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.label_click_on_me);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.label_mem);
            this.Controls.Add(this.candle_picture_box);
            this.Controls.Add(this.senior_combo_box);
            this.Controls.Add(this.middle_combo_box);
            this.Controls.Add(this.little_combo_box);
            this.Controls.Add(this.rules_box);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candle_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.TextBox rules_box;
        private System.Windows.Forms.ComboBox little_combo_box;
        private System.Windows.Forms.ComboBox middle_combo_box;
        private System.Windows.Forms.ComboBox senior_combo_box;
        private System.Windows.Forms.PictureBox candle_picture_box;
        private System.Windows.Forms.Label label_mem;
        public System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создателиToolStripMenuItem;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_click_on_me;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}