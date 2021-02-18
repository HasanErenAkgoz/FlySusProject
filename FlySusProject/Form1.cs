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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void BtnSatıs_Click(object sender, EventArgs e)
        {
            if (personelGiris(textBox1.Text.ToLower(),textBox2.Text))
            {
                MessageBox.Show("Tebrikler! Personel Girişi Başarılı");
                BiletSatışEkranı biletSatışEkranı = new BiletSatışEkranı();
                biletSatışEkranı.Show();
                this.Hide();

            }
           else if (YoneticiGiris(textBox1.Text.ToLower(), textBox2.Text))
            {
                MessageBox.Show("Tebrikler! Admin Girişi Başarılı");

                AdminEkranı adminEkranı = new AdminEkranı();
                adminEkranı.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kulanıcı adı veya parola hatalı");
            }
        }

        private void BtnYetkili_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool personelGiris(string kAdi, string kParola)
        {
           
            DataClasses1DataContext context = new DataClasses1DataContext();
            var sorgu = from p in context.Salespersons
                        where p.SalepersonEposta == kAdi
                         && p.SalespersonSıfre == kParola
                        select p;
            
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        DataClasses1DataContext context = new DataClasses1DataContext();

        private bool YoneticiGiris(string YAdi, string YParola)
        {
            var sorgu = from p in context.OperationsManagers
                        where p.OperationsmanagerEposta == YAdi
                         && p.OperationsManagerSıfre == YParola
                        select p;
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
