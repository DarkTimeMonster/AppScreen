namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ////Данный код необходим для отоброжения файлов изображений
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Данный код необходим для очистки рисунка , который вы открыли в диалоговом окне
            pictureBox1.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Данный код изменяет задний фон диалогового окна
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Данный код закрывает приложение
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Данный код необходим для растяжения рисунка.
            // Если пользователь ставит флажок растянуть то свойству SizeMode присваивается значение "Stretch" (растянуть)    
            // Если пользователь убирает флажок с растянуть то свойству SizeMode присваивается значение “Normal” (Обычный)
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
