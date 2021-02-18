using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FlySusProject
{
    public partial class KoltukSecimi : Form
    {
        public KoltukSecimi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FlySusData;Integrated Security=True");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            sahayaz();
               
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void klt4_Click(object sender, EventArgs e)
        {

        }

        private void klt5_Click(object sender, EventArgs e)
        {

        }

        private void klt7_Click(object sender, EventArgs e)
        {

        }

        private void klt8_Click(object sender, EventArgs e)
        {

        }

        private void klt9_Click(object sender, EventArgs e)
        {

        }

        private void klt12_Click(object sender, EventArgs e)
        {

        }

        private void klt11_Click(object sender, EventArgs e)
        {

        }

        private void klt10_Click(object sender, EventArgs e)
        {

        }

        private void klt13_Click(object sender, EventArgs e)
        {

        }

        private void klt14_Click(object sender, EventArgs e)
        {

        }

        private void klt15_Click(object sender, EventArgs e)
        {

        }

        private void klt18_Click(object sender, EventArgs e)
        {

        }

        private void klt17_Click(object sender, EventArgs e)
        {

        }

        private void klt16_Click(object sender, EventArgs e)
        {

        }

        private void kt19_Click(object sender, EventArgs e)
        {

        }
        public void sahayaz()
        {

            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "Select * from Flights";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                switch (oku[7].ToString())
                {
                    case "1":
                        {
                            klt1.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "2":
                        {
                            kt2.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "3":
                        {
                            klt3.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "4":
                        {
                            klt4.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }

                    case "5":
                        {
                            klt5.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }

                    case "6":
                        {
                            klt6.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "7":
                        {
                            klt7.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "8":
                        {
                            klt8.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "9":
                        {
                            klt9.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "10":
                        {
                            klt10.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "11":
                        {
                            klt11.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "12":
                        {
                            klt12.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "13":
                        {
                            klt13.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "14":
                        {
                            klt14.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "15":
                        {
                            klt15.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "16":
                        {
                            klt16.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "17":
                        {
                            klt17.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "18":
                        {
                            klt18.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "19":
                        {
                            kt19.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "20":
                        {
                            kt20.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "21":
                        {
                            kt21.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "22":
                        {
                            kt22.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "23":
                        {
                            kt23.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "24":
                        {
                            kt24.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "25":
                        {
                            kt25.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "26":
                        {
                            kt26.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "27":
                        {
                            kt27.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "28":
                        {
                            kt28.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }

                    case "29":
                        {
                            kt29.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "30":
                        {
                            kt30.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "31":
                        {
                            kt31.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "32":
                        {
                            kt32.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "33":
                        {
                            kt33.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "34":
                        {
                            kt34.ImageLocation = "kırmızıKoltuk.png";

                            break;
                        }
                    case "35":
                        {
                            kt35.ImageLocation = "kırmızıKoltuk.png";
                            break;
                        }
                    case "36":
                        {
                            kt36.ImageLocation = "kırmızıKoltuk.png";
                            break;
                        }
                }
            }
            baglan.Close();
            oku.Dispose();

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }
    }
}
