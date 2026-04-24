using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        // Event name must be provided and under 100 characters
        [Required(ErrorMessage = "Event name is required")]
        [StringLength(100, ErrorMessage = "Name too long")]
        public string Name { get; set; } = string.Empty;

        // Date must be provided
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        // Location must be provided and under 100 characters
        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location too long")]
        public string Location { get; set; } = string.Empty;
    }
}