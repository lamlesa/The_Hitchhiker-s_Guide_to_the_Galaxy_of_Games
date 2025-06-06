using System;
using System.Windows.Forms;

namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    public partial class Main_Form : Form
    {
        public Player player = new Player();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void little_combo_box_selected_item(object sender, EventArgs e)
        {
            if (little_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(1, 1, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(1, 2, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(1, 3, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(1, 4, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(1, 5, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(1, 6, player);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(1, 7, player);
                newForm.Show();
            }
        }


        private void middle_combo_box_selected_item(object sender, EventArgs e)
        {
            if (middle_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(2, 1, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(2, 2, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(2, 3, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(2, 4, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(2, 5, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(2, 6, player);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(2, 7, player);
                newForm.Show();
            }
        }



        private void senior_combo_box_selected_item(object sender, EventArgs e)
        {
            if (senior_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(3, 1, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(3, 2, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(3, 3, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(3, 4, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(3, 5, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(3, 6, player);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(3, 7, player);
                newForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CandleForm newForm = new CandleForm();
            newForm.Show();
        }
    }
}
