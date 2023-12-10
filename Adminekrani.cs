namespace Prolab2
{
    public partial class AdminEkrani : Form
    {

        public int Id { get; set; }
        public AdminEkrani()
        {
            InitializeComponent();
            Id = 1;
            PopulateDataGridView();

        }
        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (Company company in Company.Companies)
            {
                dataGridView1.Rows.Add(Id, company.Username, company.Password, company.CompanyName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firmaekleme yenifirmaekleme = new Firmaekleme();
            DialogResult result = yenifirmaekleme.ShowDialog();

            if (result == DialogResult.OK)
            {
                Company newCompany = new Company(yenifirmaekleme.KullaniciAdi, yenifirmaekleme.Sifre, yenifirmaekleme.Firmaadi);
                Company.Companies.Add(newCompany);
                Id++;
                dataGridView1.Rows.Add(Id, yenifirmaekleme.KullaniciAdi, yenifirmaekleme.Sifre, yenifirmaekleme.Firmaadi);

                PopulateDataGridView();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            Firmaekleme firmaGuncelleme = new Firmaekleme();
            firmaGuncelleme.Firmaadi = dataGridViewRow.Cells[1].Value.ToString();
            firmaGuncelleme.Sifre = dataGridViewRow.Cells[2].Value.ToString();
            
            firmaGuncelleme.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            DialogResult result = firmaGuncelleme.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            dataGridViewRow.Cells[1].Value = firmaGuncelleme.Firmaadi;
            dataGridViewRow.Cells[2].Value = firmaGuncelleme.Sifre;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;

            }
            DialogResult result = MessageBox.Show(text: "Seçili satýr silinecektir onaylýyor musunuz?", caption: "uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }
            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            dataGridView1.Rows.RemoveAt(selectedIndex);

            Company.Companies.RemoveAt(selectedIndex);
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris girisekrani = new giris();
            girisekrani.Show();
            this.Hide();
        }

        private void Hizmetb_Click(object sender, EventArgs e)
        {

        }

        private void textBoxhizmetb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
