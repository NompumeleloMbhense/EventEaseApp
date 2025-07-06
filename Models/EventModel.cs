using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventModel
    {
        
        public int Id {get; set;}

        [Required(ErrorMessage = "Event name is required")]
        [StringLength(100, ErrorMessage = "Event name cannot be longer that 100 characters")]
        [RegularExpression("^[a-zA-Z0-9\\s\\-']+$", ErrorMessage = "Name contains invalid characters")]
        [MinLength(3, ErrorMessage ="Event name must be at least 3 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Event date is required")]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Event location cannot be longer that 100 characters")]
        [MinLength(3, ErrorMessage = "Event location must be at least 3 characters")]
        [RegularExpression("^[a-zA-Z0-9\\s\\-']+$", ErrorMessage = "Invalid location format")]
        public string Location { get; set; } = string.Empty;
    }
}