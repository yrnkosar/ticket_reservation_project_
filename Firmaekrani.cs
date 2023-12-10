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
    public partial class Firmaekrani : Form
    {
        private Company loggedInCompany;
        private List<Transport> transportList = new List<Transport>();
        public int Sa { get; set; }
        public Firmaekrani()
        {
            InitializeComponent();
            Sa = 1;
        }
        public void SetLoggedInCompany(Company company)
        {
            loggedInCompany = company;
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshTransportList()
        {

            int sa = 1;
            foreach (Transport transport in loggedInCompany?.TransportList ?? new List<Transport>())
            {
                dataGridView1.Rows.Add(sa++, transport.VehicleId, transport.SeferNo);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Kayıt silinecek onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AracEkle yeniArac = new AracEkle();
            yeniArac.SetLoggedInCompany(loggedInCompany); 
            yeniArac.transportList = transportList;

            DialogResult result = yeniArac.ShowDialog();
            if (result == DialogResult.OK)
            {
                transportList.AddRange(yeniArac.transportList);

          


                dataGridView1.Rows.Add(Sa++, yeniArac.Arac, yeniArac.Sefer);

                RefreshTransportList();

            }


        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            AracEkle aracGuncelleme = new AracEkle();
            aracGuncelleme.Arac = dataGridViewRow.Cells[1].Value.ToString();
            aracGuncelleme.Sefer = dataGridViewRow.Cells[2].Value.ToString();
            aracGuncelleme.Koltuk = dataGridViewRow.Cells[3].Value.ToString();
            aracGuncelleme.Sa = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

            DialogResult result = aracGuncelleme.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            dataGridViewRow.Cells[1].Value = aracGuncelleme.Arac;
            dataGridViewRow.Cells[2].Value = aracGuncelleme.Sefer;
            dataGridViewRow.Cells[3].Value = aracGuncelleme.Koltuk;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Firmaekrani_Load(object sender, EventArgs e)
        {
            RefreshTransportList();
       
            string loggedInCompany = Company.loggedInCompany.Username;



            List<Transport> filteredTransportList = Transport.transportList
         .Where(transport => transport.CompanyName.EndsWith(loggedInCompany.Substring(loggedInCompany.Length - 1)))
         .ToList();

          
            int Sa = 1;

            foreach (var transport in filteredTransportList)
            {
                dataGridView1.Rows.Add(Sa++, transport.VehicleId, transport.SeferNo);
            }

        }
        private void ShowDailyProfit()
        {
            Company selectedCompany = Company.loggedInCompany;
            
            if (selectedCompany != null)
            {
                double dailyProfit = selectedCompany.CalculateDailyProfit();
                label1.Text = $"Günlük Kar/Zarar: {dailyProfit:C}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris girisekrani = new giris();
            girisekrani.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDailyProfit();
        }
    }
}