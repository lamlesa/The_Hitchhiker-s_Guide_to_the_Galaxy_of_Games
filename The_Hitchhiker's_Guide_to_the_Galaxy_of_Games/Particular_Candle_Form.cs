using System.Windows.Forms;
using System;

namespace The_Hitchhiker_s_Guide_to_the_Galaxy_of_Games
{
    public partial class Particular_Candle_Form : Form
    {
        public int number;
        public int count;
        public Particular_Candle_Form(int number)
        {
            InitializeComponent();
            this.number = number;
            if (number == 1)
            {
                backround.Image = Properties.Resources.candle_1;
                label.Text = "\"Цвет настроения...\"";
                description_textbox.Text = "Заранее приготовьте карточки 4-5 цветов.\r\nНапример:\r\nрозовый- восхищение\r\nкрасный- радость \r\nжёлтый- гордость\r\nсиний- печаль\r\nфиолетовый- разочарование\r\nКаждый цвет обозначает эмоцию. Говорящий тянет карточку и рассказывает историю из жизни, соответствующую цвету карточки, но если что ребёнок может поменять карточку. \r\nНе забываем хвалить ребят за открытость на свечке)))\r";
            }
            else if (number == 2)
            {
                backround.Image = Properties.Resources.candle_2;
                label.Text = "\"Путешествие в будущее\"";
                description_textbox.Text = "😎Если это свечка в начале смены, то....\r\nРебята рассказывают о предстоящей смене, как будто они уже её прожили. \r\n\r\n\U0001f973Если такую свечку провести ближе к концу смены, то можно предложить ребятам рассказать о том, что они будут делать после лагеря, их ожидания от предстоящего учебного года и тд).\r\n\r\nЗадаём тон свечки сами. Чем интереснее будет рассказ вожатого, тем сильнее  вдохновятся и раскроются дети. Не забудьте подводить итоги свечки.";
            }
            else if(number == 3)
            {
                backround.Image = Properties.Resources.candle_3;
                label.Text = "\"Шкатулка с секретами\"";
                description_textbox.Text = "Для такой свечки нужна будет небольшая коробочка или шкатулка. Туда мы положим написанные на маленьких листочках короткие темы на рассказа. Дети по очереди достают листочки и продолжают предложения.\r\n\r\n Например:\r\n\U0001f970Одно из моих заветных желаний - это...\r\n\U0001f929Моё будущее нарисовано такими красками...\r\n💅Самый счастливый день в моей жизни, был...\r\n😏Самым дорогим для меня подарком был...\r\n😻Если бы у меня был 1 миллион $, то ...\r\n😔Я не люблю, когда...\r\n❤️Самый лучший человек - это...";
            }
            description_textbox.SelectionStart = 0;
            description_textbox.SelectionLength = 0;
        }

        private void done_button_click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                Player.number_of_candles++;
            }

            if (Player.number_of_candles == 3)
            {
                Achieve_messagebox new_box = new Achieve_messagebox("Бог любит Троицу, а вы очень любите свечки, а мы любим вас !", 1);
                new_box.Show();
            }
            else
            {
                if (Player.number_of_candles == 1)
                {
                    Achieve_messagebox new_box = new Achieve_messagebox("Зажечь свечу в темноте.", 2);
                    new_box.Show();
                }
                else if (Player.number_of_candles == 2)
                {
                    Achieve_messagebox new_box = new Achieve_messagebox("Игра стоит свеч !", 3);
                    new_box.Show();
                }
            }
        }
    }
}