using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public class Trip
    {
        public string CompanyName { get; set; }
        public string VehicleId { get; set; }
        public int SeatCount { get; set; }
        public string SeferNo { get; set; }

        public Trip(string companyName, string vehicleId, int seatCount, string seferNo)
        {
            CompanyName = companyName;
            VehicleId = vehicleId;
            SeatCount = seatCount;
            SeferNo = seferNo;
        }

        public static List<Trip> CreateTripList(List<Transport> transportList)
        {
            List<Trip> tripList = new List<Trip>();

           
            var groupedTransports = transportList.GroupBy(t => new { t.CompanyName, t.VehicleId });

            foreach (var group in groupedTransports)
            {
                
                var transport = group.First();
                string companyName = transport.CompanyName;
                string vehicleId = transport.VehicleId;
                int seatCount = group.Sum(t => t.SeatCount);
                string seferNo = transport.SeferNo;

                
                Trip trip = new Trip(companyName, vehicleId, seatCount, seferNo);
                tripList.Add(trip);
            }

            return tripList;
        }
    }

}