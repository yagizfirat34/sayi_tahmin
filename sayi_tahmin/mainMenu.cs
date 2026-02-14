using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sayi_tahmin
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        SoundPlayer music = new SoundPlayer();

        private void mainMenu_Load(object sender, EventArgs e)
        {
            btnplay.BackColor = Color.Gold;

            string song = Application.StartupPath + "\\sesler\\Pixel-Guess-Parade.wav";
            music.SoundLocation = song;
            music.PlayLooping();
        }

        private void btnplay_MouseLeave(object sender, EventArgs e)
        {
            btnplay.BackColor = Color.Gold;
        }

       

        private void btnplay_MouseEnter(object sender, EventArgs e)
        {
            btnplay.BackColor = Color.Orange;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            Form1 oyun= new Form1();
            this.Hide();
            oyun.Show();
        }
    }
}
