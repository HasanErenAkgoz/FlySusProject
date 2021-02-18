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
    public partial class OnlineCheckin : Form
    {
        public OnlineCheckin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

        }
        FlightInformationsDal flightInformations = new FlightInformationsDal();
        passengerInformationsDal psn = new passengerInformationsDal();

        private void OnlineCheckin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'flySusDataDataSet.Flights' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (comboBox1.Text != "")
                {
                    MessageBox.Show("Kayıt Silme Başarılı");
                    flightInformations.Delete(new Flight
                    {
                        PnrCode = comboBox1.Text
                    });
                    psn.delete(new passangerInformation
                    {
                        passengerTc = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        PassangerCode = Convert.ToInt32(comboBox1.Text)
                    });
                    dataGridView2.DataSource = flightInformations.GetAll();
                    dataGridView1.DataSource = psn.GetAll();
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!="")
            {
                update();
                MessageBox.Show("Bizi Seçtiğiniz İçin Teşekkürler. Keyifli Yolculuklar");
                BiletAra bilet = new BiletAra();
                bilet.Show();
                this.Hide();
            }
          else
            {
                MessageBox.Show("PnrCode Mevcut Değil");
            }
        }
        public void update()
        {
            flightInformations.Update(new Flight
            {
                PnrCode = dataGridView2.CurrentRow.Cells[0].Value.ToString(),
                Departure = dataGridView2.CurrentRow.Cells[1].Value.ToString(),
                arrival = dataGridView2.CurrentRow.Cells[2].Value.ToString(),
                goingTime = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value.ToString()),
                returnTime = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[4].Value.ToString()),
                adultTicket = dataGridView2.CurrentRow.Cells[5].Value.ToString(),
                studentTicket = dataGridView2.CurrentRow.Cells[6].Value.ToString(),
                armchair = dataGridView2.CurrentRow.Cells[7].Value.ToString(),
                ticketPrice = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value.ToString()),
                rezTime = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[9].Value.ToString()),
                status = "Chec-in yapıldı. İyi Yolculuklar"
            });
            dataGridView2.DataSource = flightInformations.GetAll();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                dataGridView2.DataSource = flightInformations.PnrCode(comboBox1.Text);
                dataGridView1.DataSource = psn.PnrCode(Convert.ToInt32(comboBox1.Text));
            }


        }
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                comboBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Pnr Kodu Seçiniz");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void OnlineCheckin_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void OnlineCheckin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void OnlineCheckin_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
       
        private void OnlineCheckin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            this.flightsTableAdapter.Fill(this.flySusDataDataSet.Flights);
            dataGridView2.DataSource = flightInformations.GetAll();
            dataGridView1.DataSource = psn.GetAll();
            timer1.Interval = 10000;

        }
    }
}
