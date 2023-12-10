using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2
{
    public partial class AracEkle : Form
    {
        private Company loggedInCompany;

        public List<Transport> transportList = new List<Transport>(); // transportList özelliği
        public void SetLoggedInCompany(Company company)
        {
            loggedInCompany = company;
            // Şirketin taşıtlarını kullanarak işlemler yapabilirsiniz
        }
        private List<Transport> TransportList = new List<Transport>();
        public int Sa { get; set; }
        public string YakitTuru
        {
            get { return fueltype.Text; }
            set { fueltype.Text = value; }
        }
        public string Koltuk
        {
            get { return textBoxKoltuk.Text; }
            set { textBoxKoltuk.Text = value; }
        }
        public string Arac
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public string Sefer
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }
        public AracEkle()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Otobus")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("3");
                comboBox2.Items.Add("4");
                fueltype.Items.Clear();
                fueltype.Items.Add("Benzin");
                fueltype.Items.Add("Mazot");

            }
            else if (comboBox1.Text == "Ucak")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("5");
                comboBox2.Items.Add("6");
                fueltype.Items.Clear();
                fueltype.Items.Add("Gaz");

            }
            else if (comboBox1.Text == "Tren")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1");
                comboBox2.Items.Add("2");
                fueltype.Items.Add("Elektrik");
            }
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            //string[] araclar = { "otobüs", "uçak", "tren" };
            comboBox1.Items.Add("Otobus");
            comboBox1.Items.Add("Ucak");
            comboBox1.Items.Add("Tren");
            foreach (var company in Company.Companies)
            {
                char lastChar = company.CompanyName.ToUpper()[company.CompanyName.Length - 1];
                companytype.Items.Add(lastChar.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            Transport newTransport = new Transport(comboBox1.Text, fueltype.Text, int.Parse(textBoxKoltuk.Text), companytype.Text, comboBox2.Text);

            loggedInCompany?.AddTransport(newTransport);
            transportList.Add(newTransport);


            Sa++;

            listBox1.Items.Add("Araç:" + comboBox1.Text + " | " + "Sefer: " + comboBox2.Text + " | " + "Koltuk Adedi: " + textBoxKoltuk.Text);


            Transport.transportList.Add(newTransport);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void companytype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fueltype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
