namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    partial class CandleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandleForm));
            this.picture_box_3 = new System.Windows.Forms.PictureBox();
            this.picture_box_2 = new System.Windows.Forms.PictureBox();
            this.picture_box_1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box_3
            // 
            this.picture_box_3.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle_style3;
            this.picture_box_3.Location = new System.Drawing.Point(674, 185);
            this.picture_box_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_box_3.Name = "picture_box_3";
            this.picture_box_3.Size = new System.Drawing.Size(150, 154);
            this.picture_box_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_3.TabIndex = 5;
            this.picture_box_3.TabStop = false;
            this.picture_box_3.Click += new System.EventHandler(this.candle_3_click);
            // 
            // picture_box_2
            // 
            this.picture_box_2.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle_style2;
            this.picture_box_2.Location = new System.Drawing.Point(356, 172);
            this.picture_box_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_box_2.Name = "picture_box_2";
            this.picture_box_2.Size = new System.Drawing.Size(188, 146);
            this.picture_box_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_2.TabIndex = 4;
            this.picture_box_2.TabStop = false;
            this.picture_box_2.Click += new System.EventHandler(this.candle_2_click);
            // 
            // picture_box_1
            // 
            this.picture_box_1.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle_style1;
            this.picture_box_1.Location = new System.Drawing.Point(81, 185);
            this.picture_box_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_box_1.Name = "picture_box_1";
            this.picture_box_1.Size = new System.Drawing.Size(150, 185);
            this.picture_box_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_1.TabIndex = 3;
            this.picture_box_1.TabStop = false;
            this.picture_box_1.Click += new System.EventHandler(this.candle_1_click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(262, 54);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(362, 39);
            this.label.TabIndex = 6;
            this.label.Text = "Какая свечка ты сегодня ?";
            // 
            // background
            // 
            this.background.Image = global::The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games.Properties.Resources.candle_form_backround;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(902, 558);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 7;
            this.background.TabStop = false;
            // 
            // CandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 555);
            this.Controls.Add(this.label);
            this.Controls.Add(this.picture_box_3);
            this.Controls.Add(this.picture_box_2);
            this.Controls.Add(this.picture_box_1);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CandleForm";
            this.Text = "1, 2 или 3 ?";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box_1;
        private System.Windows.Forms.PictureBox picture_box_2;
        private System.Windows.Forms.PictureBox picture_box_3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox background;
    }
}