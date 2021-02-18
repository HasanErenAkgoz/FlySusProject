using FlySusProject.Code;
using FlySusProject.Prop;
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
    public partial class BiletSatışEkranı : Form
    {
        public BiletSatışEkranı()
        {
            InitializeComponent();
        }
        BiletAra biletara = new BiletAra();
        OnlineCheckin Onlinecheckin = new OnlineCheckin();
        FlightInformationsDal flightInformations = new FlightInformationsDal();
        passengerInformationsDal psn =new passengerInformationsDal();

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void BiletSatışEkranı_Load(object sender, EventArgs e)
        {
            panelBackground();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
        }
        public void biletAra()
        {
                panelBackground();
                panel1.BackColor = Color.SteelBlue;
                panel2.BackColor = Color.LightGreen;
                biletara.MdiParent = this;
                biletara.Show();
          
            
        }

        private void Biletara_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletAra();
            
        }
        public void panelBackground()
        {
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;


        }

        private void BltSatıs_MouseLeave(object sender, EventArgs e)
        {
        }

        private void BltSatıs_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void checkin_Click(object sender, EventArgs e)
        {
            try
            {
                OnlineCheckin online = new OnlineCheckin();
                panelBackground();
                panel1.BackColor = Color.SandyBrown;
                panel3.BackColor = Color.LightGreen;
                Onlinecheckin.MdiParent = this;
                Onlinecheckin.Show();
         
            }
            catch 
            {
              
            }
                

          
        }

        private void Onlinecheckin_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BiletSatışEkranı_MdiChildActivate(object sender, EventArgs e)
        {
          
              
            
        }

        
    }
}
