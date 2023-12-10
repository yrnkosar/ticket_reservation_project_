namespace Prolab2
{
    public partial class giris : Form
    {
        private Company loggedInCompany;
        private Admin adminUser;
        private List<Company> companies;
        public giris()
        {
            InitializeComponent();
            adminUser = new Admin("Admin", "admin123", "AdminRole");

            companies = new List<Company>();
            {
                companies.Add(new Company("companyA", "sifre1", "A"));
                companies.Add(new Company("companyB", "sifre2", "B"));
                companies.Add(new Company("companyC", "sifre3", "C"));
                companies.Add(new Company("companyD", "sifre4", "D"));
                companies.Add(new Company("companyF", "sifre5", "F"));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxka.Text;
            string enteredPassword = textBoxSifre.Text;

            if (adminUser.CheckAdminLogin(enteredUsername, enteredPassword))
            {


                AdminEkrani adminForm = new AdminEkrani();
                adminForm.Show();
                this.Hide();
            }
            else
            {

                Company companyUser = companies.Find(c => c.Login(enteredUsername, enteredPassword));
                if (companyUser != null)
                {

                    loggedInCompany = companyUser;

                    Firmaekrani firmaForm = new Firmaekrani();
                    firmaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullanıcıEkrani kullanıcıEkrani = new KullanıcıEkrani();
            kullanıcıEkrani.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
