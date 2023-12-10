using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prolab2
{
    public partial class KullanıcıEkrani : Form
    {
        private List<Route> routes;
        private List<Trip> tripList;
        int kisisayisi;
        int sayac = 0;
       

        public KullanıcıEkrani()
        {
            InitializeComponent();
            routes = Route.InitializeRoutes();
            tripList = Trip.CreateTripList(Transport.transportList);
        }

        public List<string> GetUsedSeferNo(string kalkis, string varis)
        {
            List<string> usedSeferNoList = new List<string>();

            foreach (Route route in routes)
            {
                if (route.ContainsStops(kalkis, varis))
                {
                    usedSeferNoList.Add(route.Name);
                }
            }

            return usedSeferNoList;
        }
        private List<Trip> GetUsedTrips1()
        {
            List<Trip> usedTrips = new List<Trip>();

            foreach (ListViewItem item in listViewseferler.Items)
            {
                string seferNo = item.SubItems[2].Text;
                Trip matchingTrip = tripList.FirstOrDefault(trip => trip.SeferNo == seferNo);

                if (matchingTrip != null)
                {
                    usedTrips.Add(matchingTrip);
                }
            }

            return usedTrips;
        }
        private string GetTransportationType(string vehicleId)
        {
           
            if (vehicleId.Contains("Otobus"))
            {
                return "Karayolu";
            }
            else if (vehicleId.Contains("Tren"))
            {
                return "Demiryolu";
            }
            else if (vehicleId.Contains("Ucak"))
            {
                return "Havayolu";
            }
            else
            {
                return "Unknown";
            }
        }
        public void comboBoxkalkis_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateVarisComboBox();
        }
        private List<Trip> GetUsedTrips1(string seferNo)
        {
            return tripList.Where(trip => trip.SeferNo == seferNo).ToList();
        }

        private void comboBoxvaris_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kalkis = comboBoxkalkis.Text;
            string varis = comboBoxvaris.Text;

            List<Trip> usedTrips = GetUsedTrips1(kalkis, varis);

     
            listViewseferler.Items.Clear();

         
            foreach (Route route in routes)
            {
                if (route.ContainsStops(kalkis, varis))
                {
                    string seferNo = route.Name;
                    List<Trip> matchingTrips = GetUsedTrips1(seferNo);

                   
                    usedTrips.AddRange(matchingTrips);
                }
            }

           
            listViewseferler.Items.AddRange(usedTrips.Select(trip => new ListViewItem(new[] { trip.CompanyName, trip.VehicleId, trip.SeferNo })).ToArray());
           
            UpdateTicketPrices(kalkis, varis);
        }

        private void UpdateTicketPrices(string kalkis, string varis)
        {
            foreach (ListViewItem item in listViewseferler.Items)
            {
                string seferNo = item.SubItems[2].Text;
                string vehicleId = item.SubItems[1].Text;

             
                Route matchingRoute = routes.FirstOrDefault(route => route.Name == seferNo && route.ContainsStops(kalkis, varis));

                if (matchingRoute != null)
                {
                    
                    double ticketPrice = matchingRoute.CalculateTicketPrice(GetTransportationType(vehicleId), kalkis, varis);

                    Console.WriteLine($"Route: {seferNo}, Vehicle: {vehicleId}, Ticket Price: {ticketPrice}");

                 
                    if (item.SubItems.Count == 3)
                    {
                        item.SubItems.Add(ticketPrice.ToString());
                    }
                    else
                    {
                        item.SubItems[3].Text = ticketPrice.ToString();
                    }
                }
            }
        }
        private List<Trip> GetUsedTrips1(string kalkis, string varis)
        {
            List<Trip> usedTrips = new List<Trip>();

            foreach (ListViewItem item in listViewseferler.Items)
            {
                string seferNo = item.SubItems[2].Text;

               
                Trip matchingTrip = tripList.FirstOrDefault(trip => trip.SeferNo == seferNo);

                if (matchingTrip != null)
                {
                    usedTrips.Add(matchingTrip);
                }
            }

            return usedTrips;
        }
        private double GetTicketPrice(string kalkis, string varis, string seferNo)
        {
           
            Route matchingRoute = routes.FirstOrDefault(route => route.Name == seferNo && route.ContainsStops(kalkis, varis));

            if (matchingRoute != null)
            {
               
                string vehicleId = matchingRoute.Stops[matchingRoute.Stops.IndexOf(kalkis) + 1]; 
                return matchingRoute.CalculateTicketPrice(GetTransportationType(vehicleId), kalkis, varis);
            }

            return 0; 
        }
        public void UpdateVarisComboBox()
        {
            comboBoxvaris.Items.Clear();

            string selectedKalkis = comboBoxkalkis.Text;

            foreach (Route route in routes)
            {
                if (route.Stops.Contains(selectedKalkis) && !comboBoxvaris.Items.Cast<string>().Any(item => route.Stops.Contains(item)))
                {
                    comboBoxvaris.Items.AddRange(new string[] { "İstanbul", "Ankara", "Eskişehir", "Konya", "Bilecik", "Kocaeli" });
                }
            }
        }


        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void KullanıcıEkrani_Load(object sender, EventArgs e)
        {
            comboBoxkalkis.Items.AddRange(new string[] { "İstanbul", "Ankara", "Eskişehir", "Konya", "Bilecik", "Kocaeli" });
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewseferler.SelectedItems.Count > 0)
            {
                string companyName = listViewseferler.SelectedItems[0].SubItems[0].Text;
                string vehicleId = listViewseferler.SelectedItems[0].SubItems[1].Text;
                string seferNo = listViewseferler.SelectedItems[0].SubItems[2].Text;


             
                Trip selectedTrip = tripList.FirstOrDefault(trip => trip.SeferNo == seferNo && trip.VehicleId == vehicleId && trip.CompanyName == companyName);

                if (selectedTrip != null)
                {
                    
                    koltuksecimi koltukSecimiForm = new koltuksecimi(companyName, vehicleId, seferNo, selectedTrip.SeatCount,kisisayisi,comboBoxkalkis.Text,comboBoxvaris.Text);
                    koltukSecimiForm.Show();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
              kisisayisi=(int)numericUpDown2.Value;
        }


    }
}