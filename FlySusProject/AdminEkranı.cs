using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlySusProject
{
    public partial class AdminEkranı : Form
    {
        public AdminEkranı()
        {
            InitializeComponent();
        }
        UcusBilgileri ucusBilgileri = new UcusBilgileri();
        RaporEkranı raporEkranı = new RaporEkranı();
        public void panelBackground()
        {
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
        }
        public void Ucusbilgileri()
        {
           
            ucusBilgileri.MdiParent = this;
            ucusBilgileri.Show();
            ucusBilgileri.Location = new Point(0, 0);
            panelBackground();
            panel1.BackColor = Color.Salmon;
            panel2.BackColor = Color.LightGreen;
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminEkranı_Load(object sender, EventArgs e)
        {
            panelBackground();
            Ucusbilgileri();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Bltkaydet_Click(object sender, EventArgs e)
        {
            Ucusbilgileri();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
          
            raporEkranı.MdiParent = this;
            raporEkranı.Show();
            raporEkranı.Location = new Point(0, 0);
            panelBackground();
            panel1.BackColor = Color.RoyalBlue;
            panel3.BackColor = Color.LightGreen;


        }
    }
}
