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
    public partial class UcusBilgileri : Form
    {
        public UcusBilgileri()
        {
            InitializeComponent();
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimeDonus.Text = "";
                checkCift.Checked = false;
                label4.Visible = false;
                dateTimeDonus.Visible = false;
            }
            else
            {
                comboNereye.Enabled = true;
            }
        }
        AdminFlightDal adminFlight = new AdminFlightDal();

        private void UcusBilgileri_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            dataGridView1.DataSource = adminFlight.GetAll();
            dateTimeDonus.Visible = false;
            label4.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFlightDal adminFlightDal = new AdminFlightDal();
            if (checkBox1.Checked==false)
            {
                adminFlightDal.add(new adminlflightInformations
                {
                    departureAırport = comboNereden.Text,
                    landingAırport = comboNereye.Text,
                    departureTıme = Convert.ToDateTime(dateTimeGidis.Text),
                    returnTıme = Convert.ToDateTime(dateTimeDonus.Text),
                    Price= Convert.ToInt32(textBox2.Text),
                    Company=textBox1.Text
                    
                });
                dataGridView1.DataSource = adminFlight.GetAll();
            }
            else
            {

                adminFlightDal.add(new adminlflightInformations
                {
                    departureAırport = comboNereden.Text,
                    landingAırport = comboNereye.Text,
                    departureTıme = Convert.ToDateTime(dateTimeGidis.Text),
                    Price = Convert.ToInt32(textBox2.Text),
                    Company = textBox1.Text
                });
            }
            dataGridView1.DataSource = adminFlight.GetAll();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkCift_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCift.Checked==true)
            {
                checkBox1.Checked = false;
                dateTimeDonus.Visible = true;
                label4.Visible = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
                }

        private void UcusBilgileri_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void UcusBilgileri_MouseMove(object sender, MouseEventArgs e)
        {

          
        }

        private void UcusBilgileri_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
