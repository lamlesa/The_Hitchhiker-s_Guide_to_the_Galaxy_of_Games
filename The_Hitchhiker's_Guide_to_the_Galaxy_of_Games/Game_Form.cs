using System;
using System.Windows.Forms;

namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    public partial class Game_Form : Form
    {
        public Player player_1;
        public Game_Form(int age, int id, Player player)
        {
            InitializeComponent();
            player_1 = player;
            if (age == 1)
            {
                if (id == 1)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 2)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 3)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 4)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 5)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 6)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 7)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
            }
            else if (age == 2)
            {
                if (id == 1)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 2)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 3)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 4)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 5)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 6)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 7)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
            }
            else if (age == 3)
            {
                if (id == 1)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 2)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 3)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 4)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 5)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 6)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
                else if (id == 7)
                {
                    name_textbox.Text = "";
                    description_box.Text = "";
                    picture_box.ImageLocation = "";
                }
            }
        }

        private void done_button_click(object sender, EventArgs e)
        {
            Player.number_of_games_played++;
        }
    }
}
