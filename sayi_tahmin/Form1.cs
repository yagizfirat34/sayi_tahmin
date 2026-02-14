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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tahmin, tutulan;
        int can = 7;
        bool dy;

        List<int> girilenler = new List<int>();

        SoundPlayer oyunses=new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            mesaj.Text = "1-100 arasında bir sayı tuttum. Hadi tahmin etmeye başla!";

            btnBasla.BackColor = Color.Gold;

            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();

            string sarki=Application.StartupPath + "\\sesler\\Guessing-Grid.wav";
            oyunses.SoundLocation = sarki;
            oyunses.PlayLooping();



        }

        private void main_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahmin.PerformClick();
            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
          

            //tahmin = Convert.ToInt32(txtTahmin.Text);
            if (!int.TryParse(txtTahmin.Text, out tahmin))
            {
                mesaj.Text = "Lütfen geçerli bir sayı giriniz!";
                return;
            }
            else if (tahmin <= 0 || tahmin > 100)
            {
                mesaj.Text = "Lütfen 1 ile 100 arasında bir sayı giriniz!";
                return;
            }
            if (girilenler.Contains(tahmin))
            {
                mesaj.Text = "Bu sayıyı zaten girdin, başka bir sayı dene!";
                txtTahmin.Clear();
                return;
            }
            girilenler.Add(tahmin);
            if (tahmin == tutulan)
            {
                dy = true;
                KazanmaEkrani kzn = new KazanmaEkrani();
                this.Hide();
                kzn.Show();
                oyunses.Stop();
            }
            else if (tahmin > tutulan)
            {
                Tahminler.Items.Add(tahmin + " ↓ ");
                can = can - 1;
                dy = false;
   
                 
                mesaj.Text = "Tuttuğum sayı, " + tahmin + " sayısından daha küçük!";
                    
                
            }
            else if (tahmin < tutulan)
            {
                Tahminler.Items.Add(tahmin + " ↑ ");
                can = can - 1;
                dy = false;

                mesaj.Text = "Tuttuğum sayı, " + tahmin + " sayısından daha büyük!";

            }
       
          
            
                if (can == 6)
                {
                    pbcan7.Visible = false;
                }
                else if (can == 5)
                {
                    pbcan6.Visible = false;
                }
                else if (can == 4)
                {
                    pbcan5.Visible = false;
                }
                else if (can == 3)
                {
                    pbcan4.Visible = false;
                }
                else if (can == 2)
                {
                    pbcan3.Visible = false;
                }
                else if (can == 1)
                {
                    pbcan2.Visible = false;
                }
                else if (can == 0)
                {
                    pbcan1.Visible = false;
                son_EkranKaybet kyb = new son_EkranKaybet();
                this.Hide();
                kyb.Show();
                oyunses.Stop();
                }
                
                txtTahmin.Clear();


        }

        private void btnBasla_MouseEnter(object sender, EventArgs e)
        {
            btnBasla.BackColor = Color.Orange;

        }

        private void btnBasla_MouseLeave(object sender, EventArgs e)
        {
            btnBasla.BackColor = Color.Gold;

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;
            Random tmn = new Random();
            tutulan = tmn.Next(1, 101);

            btnBasla.Dispose();



            globalData.sayi = tutulan;









        }
    }
}
