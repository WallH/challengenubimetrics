using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionesApp.Models
{
    public class Currency
    {
        private string id;
        private string symbol;
        private string description;
        private int decimal_places;
        private double todolar;
        public string Id { get => id; set => id = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Description { get => description; set => description = value; }
        public int Decimal_places { get => decimal_places; set => decimal_places = value; }
        public double Todolar { get => todolar; set => todolar = value; }
    }
}
