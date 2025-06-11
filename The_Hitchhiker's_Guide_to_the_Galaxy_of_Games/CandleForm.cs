using System;
using System.Windows.Forms;

namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    public partial class CandleForm : Form
    {
        public CandleForm()
        {
            InitializeComponent();
        }
        private void candle_1_click(object sender, EventArgs e)
        {
            Particular_Candle_Form new_form = new Particular_Candle_Form(1);
            new_form.Show();
        }
        private void candle_2_click(object sender, EventArgs e)
        {
            Particular_Candle_Form new_form = new Particular_Candle_Form(2);
            new_form.Show();
        }
        private void candle_3_click(object sender, EventArgs e)
        {
            Particular_Candle_Form new_form = new Particular_Candle_Form(3);
            new_form.Show();
        }
    }
}
