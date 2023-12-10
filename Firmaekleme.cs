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
    public partial class Firmaekleme : Form
    {
        public int Id { get; set; }
        public string Firmaadi
        {
            get { return textBoxkullanici.Text; }
            set { textBoxkullanici.Text = value; }
        }
        public string Sifre
        {
            get { return textBoxSifre.Text; }
            set { textBoxSifre.Text = value; }
        }
        public string KullaniciAdi
        {
            get { return textBoxfname.Text; }
            set { textBoxfname.Text = value; }
        }
        public Firmaekleme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Firmaekleme_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxkullanici.Text) && !string.IsNullOrEmpty(textBoxSifre.Text) && !string.IsNullOrEmpty(textBoxAracBilgisi.Text))
            {
                Company yeniFirma = new Company(textBoxkullanici.Text, textBoxSifre.Text, textBoxfname.Text);
                Company.Companies.Add(yeniFirma);
            }
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
