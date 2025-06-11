namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    partial class Achieve_messagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Achieve_messagebox));
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.text_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box
            // 
            this.pic_box.Location = new System.Drawing.Point(24, 26);
            this.pic_box.Margin = new System.Windows.Forms.Padding(2);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(111, 70);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(122, 107);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 35);
            this.button.TabIndex = 1;
            this.button.Text = "УРААА !";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text_box
            // 
            this.text_box.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.text_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box.Location = new System.Drawing.Point(153, 26);
            this.text_box.Margin = new System.Windows.Forms.Padding(2);
            this.text_box.Multiline = true;
            this.text_box.Name = "text_box";
            this.text_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_box.Size = new System.Drawing.Size(135, 70);
            this.text_box.TabIndex = 2;
            this.text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Achieve_messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(319, 151);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.button);
            this.Controls.Add(this.pic_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Achieve_messagebox";
            this.Text = "АЧИВКА !!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox text_box;
    }
}