using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prolab2
{
    public partial class BiletSatinAl : Form
    {
       public List<Passenger> passengers=new List<Passenger>();
        private string ad;
        private string soyad;
        private DateTime dogumtar;
        private string telno;
        private string tckn;
       

        public BiletSatinAl()
        {
            InitializeComponent();
            passengers = new List<Passenger>();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BiletSatinAl_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
              ad=textBoxAd.Text;
            soyad=textBoxSoyad.Text;
            dogumtar = dateTimePicker1.Value;
            telno = maskedTextBoxTel.Text;
            tckn=maskedTextBoxTC.Text;
            Passenger yeniYolcu=new Passenger(ad, soyad,tckn ,dogumtar,telno);
            passengers.Add(yeniYolcu);
          

         


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
