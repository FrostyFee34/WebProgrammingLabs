using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class RailwayRoute
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Departure time")]
        public DateTime DepartureTime { get; set; }
        [Required]
        [DisplayName("Arrival time")]
        public DateTime ArrivalTime { get; set; }
        [Required]
        [DisplayName("Departure city")]
        public string DepartureCity { get; set; }
        [Required]
        [DisplayName("Arrival city")]
        public string ArrivalCity { get; set; }
    }
}