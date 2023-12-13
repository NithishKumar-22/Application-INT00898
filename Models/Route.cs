using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Application.Models
{
    public class Route
    {

        public string? Pickup { get; set; }

        public string? Dropoff { get; set; }
        public DateOnly Date { get; set; }
        
        public int BusNumber { get; set; }
        
        public string? Time { get; set; }
    
    }
}