using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class RailwayRoute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DepartureCity { get; set; }

        public string ArrivalCity { get; set; }
    }
}