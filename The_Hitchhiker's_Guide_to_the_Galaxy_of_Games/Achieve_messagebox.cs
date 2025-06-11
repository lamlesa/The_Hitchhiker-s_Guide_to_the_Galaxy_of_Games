using System.Windows.Forms;

namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    public partial class Achieve_messagebox : Form
    {
        public Achieve_messagebox(string message, int n)
        {
            InitializeComponent();
            if (n == 1)
            {
                pic_box.Image = Properties.Resources.achieve_candle_1;
            }
            else if(n == 2)
            {
                pic_box.Image = Properties.Resources.achieve_candle_2;
            }
            else if (n == 3)
            {
                pic_box.Image = Properties.Resources.achieve_candle_3;
            }
            else if (n == 4)
            {
                pic_box.Image = Properties.Resources.achieve_games_1;
            }
            else if (n == 5)
            {
                pic_box.Image = Properties.Resources.achieve_games_2;
            }
            else if (n == 6)
            {
                pic_box.Image = Properties.Resources.achieve_games_3;
            }
            else if (n == 7)
            {
                pic_box.Image = Properties.Resources.achieve_games_4;
            }
            else if (n == 8)
            {
                pic_box.Image = Properties.Resources.achieve_games_5;
            }
            text_box.Text = message;
            button.Click += button_Click;
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
