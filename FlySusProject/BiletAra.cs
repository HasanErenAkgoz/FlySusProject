  
using FlySusProject.Code;
using FlySusProject.Prop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlySusProject
{
    public partial class BiletAra : Form
    {
        public BiletAra()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int pnrCode;
        FlightInformationsDal flight = new FlightInformationsDal();
        passengerInformationsDal passenger = new passengerInformationsDal();
        AdminFlightDal adminFlight = new AdminFlightDal();
        emptyseatDal emptyseat = new emptyseatDal();
        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BiletAra_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Önce Koltuğunuzu Seçiniz", "Bilgilendirme");
            dataGridView1.DataSource=adminFlight.GetAll();
            checkBox1.Checked = true;
            label4.Visible = false;
            dateTimeDonus.Visible = false;
            yaslar();
            comboBox1.DataSource = emptyseat.All();
            comboBox1.ValueMember = "Emptyseats";
            Enabled();

        }
        public void Enabled()
        {
            comboNereden.Enabled = false;
            comboNereden.Enabled = false;
            dateTimeDonus.Enabled = false;
            dateTimeGidis.Enabled = false;

        }
        public void yaslar()
        {

            for (int i = 0; i <= 20; i++)
            {
                comboYetıs.Items.Add(i);

                comboOgrenci.Items.Add(i);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimeDonus.Visible = false;
                label4.Visible = false;
                checkCift.Checked = false;
                Enabled();
            }
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
               
                KoltukSecimi koltukSecimi = new KoltukSecimi();
                if (checkCift.Checked==true)
                {
                    if (comboNereden.Text==comboNereye.Text)
                    {
                        MessageBox.Show("Hatalı Bir İşlem Yaptınız Lütfen Bilgilerinizi Tekrar Kontrol Edin!", "Bilgilendirme");
                    }
                    else

                {
                    MessageBox.Show("Kayıt İşlemi Başarılı Keyifli Uçuşlar Dilerim!");
                    add();
                    comboNereye.Text = "";
                    comboNereden.Text = "";

                }
                }
                else if (comboNereden.Text!=""&&comboNereye.Text!=""&&txtTc.Text!=""&&txtSoyadı.Text!=""&&txtAdı.Text!=""&&txtTelNo.Text!="")
                {
                    MessageBox.Show("Kayıt İşlemi Başarılı Keyifli Uçuşlar Dilerim!");            
                    add();
                comboNereye.Text = "";
                    comboNereden.Text = "";
               
                    
                }
        }
        emptyseatDal emptyseats = new emptyseatDal();
        DateTime bugun = DateTime.Now.AddDays(-1);

        public void add()
        {
            int price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            pnrCode = rastgele.Next(1234, 9876);
            if (comboOgrenci.Text!="")
           {
                int ogrenci = int.Parse(comboOgrenci.SelectedItem.ToString());

                price -= 50;               
                price = price * ogrenci;    
           }
            else if  (comboYetıs.Text!="")
            {
                int Yetis = int.Parse(comboYetıs.SelectedItem.ToString());
                price = price * Yetis;
            }

            passenger.add(new passangerInformation
          {
               passengerTc = txtTc.Text,
                PassangerCode = pnrCode,
              passengerName = txtAdı.Text,
              passengerSurname = txtSoyadı.Text,
              passengerTelNo = txtTelNo.Text,
              passengerAddress = txtAdres.Text
          });

            flight.Add(new Flight
            {
                PnrCode = pnrCode.ToString(),
                Departure = comboNereden.Text,
                arrival = comboNereye.Text,
                goingTime = Convert.ToDateTime(dateTimeGidis.Text),
                returnTime = Convert.ToDateTime(dateTimeDonus.Text),
                adultTicket = comboYetıs.Text,
                studentTicket = comboOgrenci.Text,
                armchair = comboBox1.Text,
                ticketPrice = Convert.ToInt32(price),
                rezTime = Convert.ToDateTime(bugun),
                status = "Chec-in bekleniyor"

            });
        }


        private void checkCift_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCift.Checked == true)
            {
                dateTimeDonus.Visible = true;
                label4.Visible = true;
                comboNereye.Enabled = true;
                dateTimeDonus.Enabled = true;
                checkBox1.Checked = false;
                Enabled();


            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void comboNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            KoltukSecimi koltukSecimi = new KoltukSecimi();
            koltukSecimi.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[4].Value == null || dataGridView1.CurrentRow.Cells[4].Value == "")
                {
                    comboNereden.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    comboNereye.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimeGidis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimeDonus.Visible = false;
                    label4.Visible = false;
                    checkCift.Checked = false;
                    checkBox1.Checked = true;
                }
                else if (dataGridView1.CurrentRow.Cells[4].Value != null || dataGridView1.CurrentRow.Cells[4].Value.ToString() != "")
                {
                    comboNereden.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    comboNereye.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimeGidis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dateTimeDonus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    dateTimeDonus.Visible = true;
                    checkBox1.Checked = false;
                    checkCift.Checked = true;
                }
            }
            catch
            {

            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BiletAra_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void BiletAra_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BiletAra_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
