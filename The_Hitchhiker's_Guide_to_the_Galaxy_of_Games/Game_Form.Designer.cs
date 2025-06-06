namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    partial class Game_Form
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
            this.description_box = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(434, 105);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(354, 315);
            this.description_box.TabIndex = 0;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(480, 41);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 26);
            this.name_textbox.TabIndex = 1;
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(101, 41);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(234, 218);
            this.picture_box.TabIndex = 2;
            this.picture_box.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "ИГРА пройдена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.done_button_click);
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.description_box);
            this.Name = "Game_Form";
            this.Text = "Game_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button button1;
    }
}