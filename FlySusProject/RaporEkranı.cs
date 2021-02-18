using FlySusProject.Code;
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
    public partial class RaporEkranı : Form
    {
        public RaporEkranı()
        {
            InitializeComponent();
        }


        FlightInformationsDal flightInformations = new FlightInformationsDal();

        private void RaporEkranı_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = flightInformations.GetAll();
        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        DateTime hafta = DateTime.Now.AddDays(7);
        DateTime Ay = DateTime.Now.AddMonths(1);
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                dataGridView1.DataSource=flightInformations.Tarih(Ay);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                dataGridView1.DataSource = flightInformations.Tarih(hafta);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void RaporEkranı_MouseDown(object sender, MouseEventArgs e)
        {

        
        }

        private void RaporEkranı_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void RaporEkranı_MouseMove(object sender, MouseEventArgs e)
        {

           
        }
    }
}
