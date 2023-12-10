using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
   

    public class Reservation
    { private List<Reservation> rezervasyonListesi = new List<Reservation>();
        public Passenger Yolcu { get; set; }
        public string Arac { get; set; }
        public int KoltukBilgisi { get; set; }
        public DateTime Tarih { get; set; }
        public string Kalkis {  get; set; }
        public string Varis {  get; set; }
        public Reservation(Passenger passenger, string arac, int koltukBilgisi, DateTime tarih, string kalkis, string varis)
        {
            Yolcu = passenger;
            Arac = arac;
            KoltukBilgisi = koltukBilgisi;
            Tarih = tarih;
            Kalkis = kalkis;
            Varis = varis;
        }

        public virtual string GetReservationDetails()
        {
            return $"Yolcu: {Yolcu.Ad} {Yolcu.Soyad} {Yolcu.Tckn} {Yolcu.DogumTarihi} {Yolcu.TelefonNo}, Araç: {Arac}, Koltuk Bilgisi: {KoltukBilgisi}, Tarih: {Tarih.ToShortDateString()}, Kalkış{Kalkis}, varış{Varis}";
        }

    }
}
