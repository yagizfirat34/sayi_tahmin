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
    public partial class son_ekran : Form
    {
        public son_ekran()
        {
            InitializeComponent();
        }

        private void son_ekran_Load(object sender, EventArgs e)
        {

        }

        private void btnTkr_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            this.Hide();
            game.Show();
        }
    }
}
