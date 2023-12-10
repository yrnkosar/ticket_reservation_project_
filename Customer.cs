using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Prolab2
    {
        public class Customer
        {
            private List<Reservation> rezervasyonListesi = new List<Reservation>();

            public void AddReservation(Reservation reservation)
            {
                rezervasyonListesi.Add(reservation);
            }

            public void RemoveReservation(Reservation reservation)
            {
                rezervasyonListesi.Remove(reservation);
            }

            public List<Reservation> GetReservations()
            {
                return rezervasyonListesi;
            }
        }
    }
}
