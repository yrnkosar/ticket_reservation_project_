
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public interface IReservable
    {
        bool IsSeatAvailable(int seatNumber);
        bool ReserveSeat(Passenger passenger, int seatNumber,DateTime tarih, string kalkis, string varis);
    }

    public class Transport:IReservable
    {
        public string VehicleId { get; set; }
        public string FuelType { get; set; }
        public int SeatCount { get; set; }
        public string CompanyName { get; set; }
        public string SeferNo { get; set; }
        public string Kalkis {  get; set; }
        public string Varis {  get; set; }
        public DateTime Tarih {  get; set; }
        
        public bool isdriver {  get; set; }

        private List<int> reservedSeats = new List<int>(); 
        public static List<Reservation> rezervasyonListesi = new List<Reservation>();
        public Transport(string vehicleId, string fuelType, int seatCount, string companyName, string seferNo)
        {
            VehicleId = vehicleId;
            FuelType = fuelType;
            SeatCount = seatCount;
            CompanyName = companyName;
            SeferNo = seferNo;
        }
        public double GetFuelPrice(string companyName)
        {
            
            switch (FuelType)
            {
                case "Benzin":
                    return companyName == "A" ? 10 : 0;
                case "Motorin":
                    return companyName == "B" ? 5 : companyName == "C" ? 6 : 0; 
                case "Elektrik":
                    return companyName == "D" ? 3 : 0; 
                case "Gaz":
                    return companyName == "F" ? 20 : companyName == "C" ? 25 : 0; 
                default:
                    return 0;
            }
        }
        public static List<Transport> transportList= new List<Transport>
        {
                new Transport("Otobus 1", "Benzin", 20, "A", "3"),
                new Transport("Otobus 2", "Benzin", 15, "A", "3"),
                new Transport("Otobus 1", "Motorin", 15, "B", "3"),
                new Transport("Otobus 2", "Motorin", 20, "B", "4"),
                new Transport("Otobus 1", "Motorin", 20, "C", "4"),
                new Transport("Ucak 1", "Gaz", 30, "C", "5"),
                new Transport("Ucak 2", "Gaz", 30, "C", "5"),
                new Transport("Tren 1", "Elektrik", 25, "D", "1"),
                new Transport("Tren 2", "Elektrik", 25, "D", "2"),
                new Transport("Tren 3", "Elektrik", 25, "D", "2"),
                new Transport("Ucak 1", "Gaz", 30, "F", "6"),
                new Transport("Ucak 2", "Gaz", 30, "F", "6")
            };


        public bool IsSeatAvailable(int seatNumber)
        {
            return !reservedSeats.Contains(seatNumber);
        }

        public int GenerateRandomReservedSeats(int SeatCount)
        {
            Random random = new Random();
            int randomReservedSeats = random.Next(1, SeatCount + 1); 

            for (int i = 0; i < randomReservedSeats; i++)
            {
                int randomSeatNumber;
                do
                {
                    randomSeatNumber = random.Next(1, SeatCount + 1);
                } while (reservedSeats.Contains(randomSeatNumber)); 

                reservedSeats.Add(randomSeatNumber);
            }

            return randomReservedSeats;
        }
        public double CalculateTotalPrice(string CompanyName,string SeferNo,int Seatcount)
        {
           
            double personnelExpenses = CalculatePersonnelExpenses(CompanyName);

            double ticketPrice = CalculateTicketPrice(SeferNo);
            double fuelCost = CalculateFuelCost(SeferNo);
            int randomReservedSeats = GenerateRandomReservedSeats(SeatCount);
            double totalTicketPrice = randomReservedSeats * ticketPrice;
            double fuelPrice = GetFuelPrice(CompanyName);
            
            double totalExpenses = personnelExpenses + fuelCost;
            double totalRevenue = totalTicketPrice - totalExpenses;


            return totalRevenue;
        }
        private double CalculateTicketPrice(string SeferNo)
        {double ticketPrice = 0;
            switch (SeferNo)
            {
                case "1":
                    ticketPrice = 250;
                    break;
                case "2":
                    ticketPrice = 300;
                    break;
                case "3":
                    ticketPrice = 300;
                    break;
                case "4":
                    ticketPrice = 300;
                    break;
                case "5":
                    ticketPrice = 1200;
                    break;
                case "6":
                    ticketPrice = 1000;
                    break;

            }
            return ticketPrice;
        }
        public double CalculatePersonnelExpenses(String companyName)
        {
           
            double driverSalary = 0;
            double serviceSalary = 0;

        
            switch (companyName)
            {
                case "A":
                    driverSalary = 5000;
                    serviceSalary = 2000;
                    return 2 * 7000;
                case "B":
                    driverSalary = 3000;
                    serviceSalary = 1500;
                    return 2 * 4500;
                case "C (otobüs)":
                    driverSalary = 4000;
                    serviceSalary = 2000;
                    return 2 * 6000;
                case "D":
                    driverSalary = 2000;
                    serviceSalary = 1000;
                    return 2 * 3000;
                case "F":
                    driverSalary = 7500;
                    serviceSalary = 4000;
                    return 2 * 11500;
                case "C (uçak)":
                    driverSalary = 10000;
                    serviceSalary = 6000;
                    return 2 * 16000;
                default:          
                    return 2 * (driverSalary + serviceSalary);
            }
        }
        private double CalculateFuelCost(string SeferNo)
        {
            double fuelPrice = GetFuelPrice(CompanyName);
            switch (SeferNo) {
                case "1":
                    return 375 * fuelPrice; 
                case "2":
                    return 450 * fuelPrice;
                case "3":
                    return 500 * fuelPrice;
                case "4":
                    return 600 * fuelPrice;
                case "5":
                    return 300 * fuelPrice;
                case "6":
                    return 250 * fuelPrice;
                default:
                    return 0; 
            }
        }
        public bool ReserveSeat(Passenger passenger, int seatNumber, DateTime tarih,string kalkis,string varis)
        {
            if (!IsSeatAvailable(seatNumber))
            {
                return false;
            }
            

            Reservation newReservation = new Reservation(passenger,VehicleId,seatNumber,tarih,kalkis,varis);
            newReservation.Yolcu = passenger;
            newReservation.Arac = this.VehicleId;
            newReservation.KoltukBilgisi = seatNumber;
            rezervasyonListesi.Add(newReservation);
            reservedSeats.Add(seatNumber); 

            return true;
            
        }

    }
    }

