using System;

namespace Lab1.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string PassengerFullName { get; set; }
        public double Price { get; set; }
        public RailwayRoute Route { get; set; }
        public int RailwayRouteId { get; set; }
    }
}