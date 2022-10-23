namespace Music_Player
{
    public partial class Form1 : Form
    {
        private Mp3Players mp3player=new Mp3Players();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3player.Open(ofd.FileName);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp3player.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp3player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}