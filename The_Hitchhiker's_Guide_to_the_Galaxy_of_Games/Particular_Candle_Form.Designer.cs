namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    partial class Particular_Candle_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Particular_Candle_Form));
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.backround = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backround)).BeginInit();
            this.SuspendLayout();
            // 
            // description_textbox
            // 
            this.description_textbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.description_textbox.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.Location = new System.Drawing.Point(118, 114);
            this.description_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_textbox.Size = new System.Drawing.Size(488, 292);
            this.description_textbox.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(158, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(411, 34);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backround
            // 
            this.backround.Location = new System.Drawing.Point(0, 0);
            this.backround.Name = "backround";
            this.backround.Size = new System.Drawing.Size(732, 468);
            this.backround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backround.TabIndex = 2;
            this.backround.TabStop = false;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button.Location = new System.Drawing.Point(648, 362);
            this.button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(45, 46);
            this.button.TabIndex = 3;
            this.button.Text = "✔";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.done_button_click);
            // 
            // Particular_Candle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 463);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.backround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Particular_Candle_Form";
            this.Text = "It\'s svechka time";
            ((System.ComponentModel.ISupportInitialize)(this.backround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox backround;
        private System.Windows.Forms.Button button;
    }
}