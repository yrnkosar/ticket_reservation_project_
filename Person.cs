using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    public abstract class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Person(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
    }
    

    public class Personel : Person
    {
        
        public string Departman { get; set; }
        public string Firma { get; set; }
        public Personel(string ad, string soyad,string departman,string firma):base(ad, soyad) {
        
            Departman = departman;
            Firma = firma; }
        public decimal GetPersonnelFees(string companyName, string vehicleId)
        {
            
            int personnelCount = 4;

            decimal driverFee = 0;
            decimal servicePersonnelFee = 0;

            switch (companyName)
            {
                case "A":
                    driverFee = vehicleId.Contains("Ucak") ? 5000 : 3000;
                    servicePersonnelFee = vehicleId.Contains("Ucak") ? 2000 : 1500;
                    break;
                case "B":
                    driverFee = 4000;
                    servicePersonnelFee = 2000;
                    break;
                case "C":
                    driverFee = vehicleId.Contains("Ucak") ? 10000 : 4000;
                    servicePersonnelFee = vehicleId.Contains("Ucak") ? 6000 : 2000;
                    break;
                case "D":
                    driverFee = 2000;
                    servicePersonnelFee = 1000;
                    break;
                case "F":
                    driverFee = 7500;
                    servicePersonnelFee = 4000;
                    break;
                default:
                   
                    break;
            }

            
            decimal totalFees = personnelCount * (driverFee + servicePersonnelFee);

            return totalFees;
        }
       

    }

    public class Passenger : Person
    {
       
        public string Tckn {  get; set; }
        public DateTime DogumTarihi {  get; set; }
        public string TelefonNo {  get; set; }

        public Passenger(string ad,string soyad,string tckn, DateTime dogumtar, string telno ):base(ad, soyad)
        {
            Tckn = tckn;
            DogumTarihi = dogumtar;
            TelefonNo = telno;

        }
    }


}
