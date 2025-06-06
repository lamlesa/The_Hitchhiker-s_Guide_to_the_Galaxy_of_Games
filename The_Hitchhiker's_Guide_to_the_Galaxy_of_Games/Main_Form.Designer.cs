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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.little_combo_box = new System.Windows.Forms.ComboBox();
            this.middle_combo_box = new System.Windows.Forms.ComboBox();
            this.senior_combo_box = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 258);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 306);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ИТАК выберите возраст для которого вам нужны игры";
            // 
            // little_combo_box
            // 
            this.little_combo_box.FormattingEnabled = true;
            this.little_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.little_combo_box.Location = new System.Drawing.Point(650, 203);
            this.little_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.little_combo_box.Name = "little_combo_box";
            this.little_combo_box.Size = new System.Drawing.Size(180, 28);
            this.little_combo_box.TabIndex = 5;
            this.little_combo_box.Text = "МЛАДШИИИИЕ";
            this.little_combo_box.SelectedIndexChanged += new System.EventHandler(this.little_combo_box_selected_item);
            // 
            // middle_combo_box
            // 
            this.middle_combo_box.FormattingEnabled = true;
            this.middle_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.middle_combo_box.Location = new System.Drawing.Point(650, 291);
            this.middle_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.middle_combo_box.Name = "middle_combo_box";
            this.middle_combo_box.Size = new System.Drawing.Size(180, 28);
            this.middle_combo_box.TabIndex = 6;
            this.middle_combo_box.Text = "СРЕДНИЕ";
            // 
            // senior_combo_box
            // 
            this.senior_combo_box.FormattingEnabled = true;
            this.senior_combo_box.Items.AddRange(new object[] {
            "На знакомство",
            "На сплочение",
            "На примирение",
            "На выявление лидера",
            "В плохую погоду",
            "Пятиминутка",
            "КТД"});
            this.senior_combo_box.Location = new System.Drawing.Point(650, 408);
            this.senior_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.senior_combo_box.Name = "senior_combo_box";
            this.senior_combo_box.Size = new System.Drawing.Size(180, 28);
            this.senior_combo_box.TabIndex = 7;
            this.senior_combo_box.Text = "СТАРШИЕ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.avatar_image1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle;
            this.pictureBox2.Location = new System.Drawing.Point(792, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 612);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.senior_combo_box);
            this.Controls.Add(this.middle_combo_box);
            this.Controls.Add(this.little_combo_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox little_combo_box;
        private System.Windows.Forms.ComboBox middle_combo_box;
        private System.Windows.Forms.ComboBox senior_combo_box;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}