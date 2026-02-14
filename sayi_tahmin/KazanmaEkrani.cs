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
    public partial class KazanmaEkrani : Form
    {
        public KazanmaEkrani()
        {
            InitializeComponent();
        }

        private void KazanmaEkrani_Load(object sender, EventArgs e)
        {
            btnTekrar.BackColor = Color.Gold;
            btnAnaSayfaa.BackColor = Color.Gold;

            label1.Text= "Tebrikler, kazandın. Tuttuğum sayı, "+globalData.sayi.ToString()+" idi. Tekrar oynamak ister misin?";
        }

        private void btnAnaSayfaa_Click(object sender, EventArgs e)
        {
            mainMenu anaMenu = new mainMenu();
            this.Hide();
            anaMenu.Show();
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            Form1 game= new Form1();
            this.Hide();
            game.Show();
        }

        private void btnTekrar_MouseEnter(object sender, EventArgs e)
        {
            btnTekrar.BackColor = Color.Orange;
        }

        private void btnTekrar_MouseLeave(object sender, EventArgs e)
        {
            btnTekrar.BackColor = Color.Gold;
        }

        private void btnAnaSayfaa_MouseEnter(object sender, EventArgs e)
        {
            btnAnaSayfaa.BackColor = Color.Orange;
        }

        private void btnAnaSayfaa_MouseLeave(object sender, EventArgs e)
        {
            btnAnaSayfaa.BackColor = Color.Gold;
        }
    }
}
