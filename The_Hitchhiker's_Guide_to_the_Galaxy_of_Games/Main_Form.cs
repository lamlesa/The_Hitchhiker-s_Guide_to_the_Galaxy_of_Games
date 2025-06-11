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
            rules_box.SelectionStart = 0;
            rules_box.SelectionLength = 0;
            this.FormClosing += Main_Form_FormClosing;
        }


        // для младших
        private void little_combo_box_selected_item(object sender, EventArgs e)
        {
            if (little_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(1, 1, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(1, 2, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(1, 3, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(1, 4, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(1, 5, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(1, 6, this);
                newForm.Show();
            }
            else if (little_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(1, 7, this);
                newForm.Show();
            }
        }


        // для средних
        private void middle_combo_box_selected_item(object sender, EventArgs e)
        {
            if (middle_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(2, 1, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(2, 2, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(2, 3, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(2, 4, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(2, 5, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(2, 6, this);
                newForm.Show();
            }
            else if (middle_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(2, 7, this);
                newForm.Show();
            }
        }


        // для старших
        private void senior_combo_box_selected_item(object sender, EventArgs e)
        {
            if (senior_combo_box.SelectedItem.ToString() == "На знакомство")
            {
                Game_Form newForm = new Game_Form(3, 1, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На сплочение")
            {
                Game_Form newForm = new Game_Form(3, 2, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На примирение")
            {
                Game_Form newForm = new Game_Form(3, 3, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "На выявление лидера")
            {
                Game_Form newForm = new Game_Form(3, 4, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "В плохую погоду")
            {
                Game_Form newForm = new Game_Form(3, 5, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "Пятиминутка")
            {
                Game_Form newForm = new Game_Form(3, 6, this);
                newForm.Show();
            }
            else if (senior_combo_box.SelectedItem.ToString() == "КТД")
            {
                Game_Form newForm = new Game_Form(3, 7, this);
                newForm.Show();
            }
        }

        private void picture_box_Click(object sender, EventArgs e)
        {
            CandleForm new_form = new CandleForm();
            new_form.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void show_what_is_this_about(object sender, EventArgs e)
        {
            MessageBox.Show("Это приложение позволит вам быстро и удобно подобрать игру, в которую вы можете сыграть со своим отрядом ! Have fun !", "О приложении", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void help(object sender, EventArgs e)
        {
            Help help_window = new Help();
            help_window.Show();
        }

        private void creators(object sender, EventArgs e)
        {
            MessageBox.Show("Пенсионер без пенсии АКА Лилия\nGulnaz\nanna semenova\nЛяйсан\nЛина\nДаша\nЛеся🐾", "Создатели", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
