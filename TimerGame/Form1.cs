using System.Diagnostics.Metrics;

namespace TimerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Location = new Point(
                rd.Next(0, this.ClientSize.Width - pictureBox1.Width),
                rd.Next(0, this.ClientSize.Height - pictureBox1.Height));
            pictureBox2.Location = new Point(
                rd.Next(0, this.ClientSize.Width - pictureBox2.Width),
                rd.Next(0, this.ClientSize.Height - pictureBox2.Height));

        }

        int _counter = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //green
            _counter++;
            if (_counter == 3)
            {
                label1.Text = $"Score: {_counter}";
                MessageBox.Show("You won");
                restartToolStripMenuItem_Click_1(sender, e);

            }
            label1.Text = $"Score: {_counter}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _counter--;
            if (_counter <= 0)
            {
                label1.Text = $"Score: {_counter}";
                MessageBox.Show("You lost");
                restartToolStripMenuItem_Click_1(sender, e);
            }
            label1.Text = $"Score: {_counter}";
        }


        private void restartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            _counter = 0;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pasueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            label1.Text = $"Score: {_counter}";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 50;
        }
    }
}