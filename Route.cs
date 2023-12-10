using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab2
{
    class Route
    {
        public string Name { get; set; }
        public List<string> Stops { get; set; } = new List<string>();

        public Route(string name, List<string> stops)
        {
            Name = name;
            Stops = stops;
        }

        public bool ContainsStops(string stop1, string stop2)
        {
            return Stops.Contains(stop1) && Stops.Contains(stop2);
        }
        public static List<Route> InitializeRoutes()
        {
            return new List<Route>
        {
            new Route("1", new List<string> { "İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Ankara", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" }),
            new Route("2", new List<string> { "İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Konya", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" }),
            new Route("3", new List<string> { "İstanbul", "Kocaeli", "Ankara", "Kocaeli", "İstanbul", "Kocaeli", "Ankara", "Kocaeli","İstanbul" }),
            new Route("4", new List<string> { "İstanbul", "Kocaeli", "Eskişehir", "Konya", "Eskişehir", "Kocaeli", "İstanbul", "Kocaeli", "İstanbul" }),
            new Route("5", new List<string> { "İstanbul", "Konya", "İstanbul" }),
            new Route("6", new List<string> { "İstanbul", "Ankara", "İstanbul" })
        };
        }


        public double CalculateTicketPrice(string transportationType, string kalkis, string varis)
        {
           
            Dictionary<string, Dictionary<string, double>> ticketPrices = new Dictionary<string, Dictionary<string, double>>
    {
        {
            "Karayolu", new Dictionary<string, double>
            {
                { "İstanbul", 0 },
                { "Kocaeli", 100 },
                { "Bilecik", 00 },
                { "Ankara", 500 },
                { "Eskişehir", 300 },
                { "Konya", 600 }
            }
        },
        {
            "Demiryolu", new Dictionary<string, double>
            {
                { "İstanbul", 0 },
                { "Kocaeli", 75 },
                { "Bilecik", 225 },
                { "Ankara", 375 },
                { "Eskişehir", 300 },
                { "Konya", 450 }
            }
        },
        {
            "Havayolu", new Dictionary<string, double>
            {
                { "İstanbul", 0 },
                { "Ankara", 1000 },
                { "Konya", 1200 }
            }
        }
    };

            double ticketPrice = 0;

          
            if (ticketPrices.ContainsKey(transportationType) && ticketPrices[transportationType].ContainsKey(kalkis) && ticketPrices[transportationType].ContainsKey(varis))
            {
                ticketPrice = ticketPrices[transportationType][varis] - ticketPrices[transportationType][kalkis];
            }
            else
            {
                Console.WriteLine($"Hesaplama yapılamadı. Transport: {transportationType}, Kalkış: {kalkis}, Varış: {varis}");
            }

            return Math.Abs(ticketPrice);
        }
    }
}