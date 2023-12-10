using System;
using System.Collections.Generic;
namespace Prolab2{
    public abstract class Vehicle
    {
        public string VehicleName { get; set; }
        public string FuelType { get; set; }
        public int SeatCount { get; set; }
        public Company Company { get; set; }
        public Dictionary<string, double> FuelPrices { get; set; } 
        
        public static List<Transport> transportList = Transport.transportList;
        public Vehicle(string vehicleName, string fuelType, int seatCount, Company company)
        {
            VehicleName = vehicleName;
            FuelType = fuelType;
            SeatCount = seatCount;
            FuelPrices = new Dictionary<string, double>();
            Company = company;
        }

        public void SetFuelPrice(string fuelType, double fuelPrice)
        {
            if (!FuelPrices.ContainsKey(fuelType))
            {
                FuelPrices.Add(fuelType, fuelPrice);
            }
            else
            {
                FuelPrices[fuelType] = fuelPrice;
            }
        }
        public abstract double CalculateFuelCost(string seferNo, string companyName, double distance);
  

        private double GetDistanceForSefer(string seferNo)
            {
      
            switch (seferNo)
        {
            case "1":
                return 750;
            case "2":
                return 900;
            case "3":
                return 1000;
            case "4":
                return 1200;
            case "5":
                return 600;
            case "6":
                return 500;
            default:
                return 0;
                }
                      }
        public double GetFuelPrice(string companyName)
        {
          
            switch (FuelType)
            {
                case "Benzin":
                    return companyName == "A" ? 10 : 0; 
                    return companyName == "B" ? 5 : companyName == "C" ? 6 : 0; 
                case "Elektrik":
                    return companyName == "D" ? 3 : 0; 
                case "Gaz":
                    return companyName == "F" ? 20 : companyName == "C" ? 25 : 0; 
                default:
                    return 0;
            }
        }

        
    }
  
    public class Bus : Vehicle
    {
        public Bus(string vehicleName, string fuelType, int seatCount, Company company)
            : base(vehicleName, fuelType, seatCount, company )
        {
            
        }

        public override double CalculateFuelCost(string seferNo, string companyName, double distance)
        {
            double totalFuelCost = 0.0;

            var vehiclesOnRoute = transportList
                .Where(t => t.SeferNo == seferNo && t.CompanyName == companyName);

            foreach (var vehicle in vehiclesOnRoute)
            {
                double fuelCost = vehicle.GetFuelPrice(companyName) * distance;
                totalFuelCost += fuelCost;
            }

            return totalFuelCost;
        }
    }
    public class Train : Vehicle
    {
        public Train(string vehicleName, string fuelType, int seatCount, Company company)
            : base(vehicleName, fuelType, seatCount, company)
        {
            
        }

        public override double CalculateFuelCost(string seferNo, string companyName, double distance)
        {
            double totalFuelCost = 0.0;

            var vehiclesOnRoute = transportList
                .Where(t => t.SeferNo == seferNo && t.CompanyName == companyName);

            foreach (var vehicle in vehiclesOnRoute)
            {
                double fuelCost = vehicle.GetFuelPrice(companyName) * distance;
                totalFuelCost += fuelCost;
            }

            return totalFuelCost;
        }
    }

    
    public class Airplane : Vehicle
    {
        public Airplane(string vehicleName, string fuelType, int seatCount, Company company)
            : base(vehicleName, fuelType, seatCount, company)
        {
        }

        public override double CalculateFuelCost(string seferNo, string companyName, double distance)
        {
            double totalFuelCost = 0.0;

            var vehiclesOnRoute = transportList
                .Where(t => t.SeferNo == seferNo && t.CompanyName == companyName);

            foreach (var vehicle in vehiclesOnRoute)
            {
                double fuelCost = vehicle.GetFuelPrice(companyName) * distance;
                totalFuelCost += fuelCost;
            }

            return totalFuelCost;
        }
    }

}