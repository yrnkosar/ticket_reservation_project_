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
    public partial class koltuksecimi : Form
    {
        private List<Reservation> rezervasyonListesi = new List<Reservation>();

        private List<Color> boyananKoltukRenkleri = new List<Color>();
        private string ad; 
        private string soyad;
        private string tckn;
        private DateTime dogumtar;
        private string telno;
        private string vehicleId;
        private string fuelType;
        private string companyName;
        private string seferNo;
        private int seatCount;
        private DateTime tarih;
        private string kalkis;
        private string varis;
        private List<Button> selectedSeats = new List<Button>();
        private int  kisisayisi;
        Random random = new Random();

        public koltuksecimi(string companyName, string vehicleId, string seferNo, int seatCount, int kisisayisi,string kalkis,string varis)
        {
            InitializeComponent();

            this.seferNo = seferNo;
            this.vehicleId = vehicleId;
            this.companyName = companyName;
            this.seatCount = seatCount;
            this.kisisayisi = kisisayisi;
            KoltukDoldur();
            BoyaRastgeleKoltuklari(seatCount);
        }
        private void KoltukDoldur()
        {
            if (seatCount % 4 == 1)
            {
                KoltukDoldur((seatCount / 4), 1);
            }
            if (seatCount % 4 == 3)
            {
                KoltukDoldur((seatCount / 4), 3);
            }
            if (seatCount % 4 == 2)
            {
                KoltukDoldur((seatCount / 4), 2);
            }
            else if (seatCount % 4 == 0)
            {
                KoltukDoldur(seatCount / 4, 4);
            }

            BoyaRastgeleKoltuklari(seatCount);

            void KoltukDoldur(int sira, int arkabesliMi)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }
                int koltukNo = 1;
                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arkabesliMi == 1)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }

                        }
                        else if (arkabesliMi == 2)
                        {
                            if ((i != sira - 1 && j == 2) && (i != sira - 2 && j == 2))
                            {
                                continue;
                            }
                        }
                        else if (arkabesliMi == 3)
                        {
                            if ((i != sira - 1 && j == 2) && (i != sira - 2 && j == 2) && (i != sira - 3 && j == 2))
                            {
                                continue;
                            }

                        }
                        else
                        {
                            if (j == 2)
                            { continue; }
                        }

                        Button koltuk = new Button();
                        koltuk.MouseDown += koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                       
                      
                        this.Controls.Add(koltuk);
                    }
                }
            }
        }


        void BoyaRastgeleKoltuklari(int seatCount)
        {
            boyananKoltukRenkleri.Clear();

            List<Button> tumKoltuklar = this.Controls.OfType<Button>().ToList();

            tumKoltuklar.RemoveAll(k => boyananKoltukRenkleri.Contains(k.BackColor));

            int boyanacakKoltukSayisi = Math.Min(seatCount, tumKoltuklar.Count);
            for (int i = 0; i < boyanacakKoltukSayisi; i++)
            {
                Button rastgeleKoltuk = SecilmemisRastgeleKoltuk(tumKoltuklar);
                if (rastgeleKoltuk != null)
                {
                    Color maviRenk = Color.Blue;
                    rastgeleKoltuk.BackColor = maviRenk;
                    boyananKoltukRenkleri.Add(maviRenk);
                }
            }
        }
        Button SecilmemisRastgeleKoltuk(List<Button> tumKoltuklar)
        {
            if (tumKoltuklar.Count == 0)
            {
                return null;
            }
            int randomIndex = random.Next(0, tumKoltuklar.Count);
            return tumKoltuklar[randomIndex];
        }

        private void koltuksecimi_Load(object sender, EventArgs e)
        {

        }
        private void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            Button tiklananButon = sender as Button;

          
            if (tiklananButon.BackColor == Color.Blue)
            {
                MessageBox.Show("Bu koltuk zaten rezerve edilmiş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Passenger passenger = new Passenger(ad, soyad, tckn, dogumtar, telno);
            int koltukNo = int.Parse(tiklananButon.Text);
            Transport secilenTransport = Transport.transportList.FirstOrDefault(t => t.VehicleId == vehicleId && t.SeferNo == seferNo);
            selectedSeats.Add(tiklananButon);
            tiklananButon.BackColor = Color.Green;

            if (e.Button == MouseButtons.Right) 
            {
                if (secilenTransport != null)
                {
                    bool isSeatReserved = secilenTransport.ReserveSeat(passenger, koltukNo, tarih, kalkis, varis);

                    if (isSeatReserved)
                    {
                        tiklananButon.BackColor = Color.Blue;
                        MessageBox.Show("Koltuk rezerve edildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
                    
                    }
                    else
                    {
                        MessageBox.Show("Koltuk rezerve edilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Uygun sefer bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (selectedSeats.Count == kisisayisi)
            {
               
                foreach (Button selectedSeat in selectedSeats)
                {
                    selectedSeat.BackColor = Color.Blue;

                    BiletSatinAl bsa = new BiletSatinAl();
                    DialogResult sonuc = bsa.ShowDialog();

                }
                selectedSeats.Clear();

                MessageBox.Show($"Başarıyla {kisisayisi} koltuk işlemi tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reservation yeniRezervasyon = new Reservation(passenger, vehicleId, koltukNo, tarih, kalkis, varis);
                rezervasyonListesi.Add(yeniRezervasyon);
             
                
            }
            else
            {
                MessageBox.Show($"Lütfen toplam {kisisayisi} koltuk seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


       
        } } 

       