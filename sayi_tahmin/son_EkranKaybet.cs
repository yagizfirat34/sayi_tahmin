using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmin
{
    public partial class son_EkranKaybet : Form
    {
        public son_EkranKaybet()
        {
            InitializeComponent();
        }

        private void son_EkranKaybet_Load(object sender, EventArgs e)
        {
            label1.Text="Kaybettin! Tuttuğum sayı, "+globalData.sayi.ToString()+" idi.";

            btnTkr.BackColor = Color.Gold;
            btnAnaMenu.BackColor = Color.Gold;

        }

        private void btnTkr_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            this.Hide();
            game.Show();
        }

        private void btnTkr_MouseEnter(object sender, EventArgs e)
        {
            btnTkr.BackColor = Color.Orange;

        }

        private void btnTkr_MouseLeave(object sender, EventArgs e)
        {
            btnTkr.BackColor = Color.Gold;

        }

        private void btnAnaMenu_MouseEnter(object sender, EventArgs e)
        {
            btnAnaMenu.BackColor = Color.Orange;
        }

        private void btnAnaMenu_MouseLeave(object sender, EventArgs e)
        {
            btnAnaMenu.BackColor = Color.Gold;
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();

            this.Hide();
            menu.Show();
        }
    }
}
