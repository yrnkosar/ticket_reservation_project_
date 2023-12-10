using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public interface IProfitable
    {
       double CalculateDailyProfit(); 
    }
    public class Company : User, IProfitable
    {
        public string CompanyName { get; set; }
        public static Company loggedInCompany { get; private set; }
        public Dictionary<string, double> VehicleFuelPrices { get; set; }
        public List<Transport> TransportList { get; set; } = new List<Transport>();
       
        public static List<Company> Companies = new List<Company>
        {
        new Company("companyA", "sifre1","A"),
        new Company("companyB", "sifre2", "B"),
        new Company("companyC", "sifre3", "C"),
        new Company("companyD", "sifre4", "D"),
        new Company("companyF", "sifre5", "F"),
        };
        public Company(string username, string password, string companyName) : base(username, password)
        {
            CompanyName = companyName;
            VehicleFuelPrices = new Dictionary<string, double>();

        }
        public double CalculateDailyProfit()
        { 
            double totalProfit = 0;

            foreach (var transport in Transport.transportList.Where(t => t.CompanyName == CompanyName))
            {
                double transportProfit = transport.CalculateTotalPrice(CompanyName,transport.SeferNo,transport.SeatCount);
                totalProfit += transportProfit;
            }
            double personnelExpenses = CalculateTotalPersonnelExpenses(CompanyName);
            totalProfit -= personnelExpenses;

            return totalProfit;
        }
       
        public double CalculateTotalPersonnelExpenses(string CompanyName)
        {
            double totalPersonnelExpenses = 0;

            foreach (var transport in Transport.transportList.Where(t => t.CompanyName == CompanyName))
            {
                
                double transportPersonnelExpenses = transport.CalculatePersonnelExpenses(CompanyName);
                totalPersonnelExpenses += transportPersonnelExpenses;
            }

            return totalPersonnelExpenses;
        }

        public void SetVehicleFuelPrice(string vehicleName, double fuelPrice)
        {
            if (!VehicleFuelPrices.ContainsKey(vehicleName))
            {
                VehicleFuelPrices.Add(vehicleName, fuelPrice);
            }
            else
            {
                VehicleFuelPrices[vehicleName] = fuelPrice;
            }
        }

        public double GetVehicleFuelPrice(string vehicleName)
        {
            if (VehicleFuelPrices.ContainsKey(vehicleName))
            {
                return VehicleFuelPrices[vehicleName];
            }
            else
            {
                
                return 0.0;
            }
        }
    
    public override bool Login(string enteredUsername, string enteredPassword)
        {
            foreach (var company in Companies)
            {
                if (company.Username == enteredUsername && company.Password == enteredPassword)
                {
                    loggedInCompany = company;
                    Firmaekrani companyForm = new Firmaekrani();
                    
                    return true;
                }
            }
            return false;
        }
        public void AddTransport(Transport newTransport)
        {
            Transport.transportList.Add(newTransport);
        }

    }

}

