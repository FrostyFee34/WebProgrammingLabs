using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Passenger full name")]
        [Required]
        public string PassengerFullName { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than zero")]
        public double Price { get; set; }
        public RailwayRoute Route { get; set; }
        [Required]
        public int RailwayRouteId { get; set; }
    }
}