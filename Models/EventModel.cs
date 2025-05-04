using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventModel
    {
        
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Event name is required")]
        [StringLength(100, ErrorMessage = "Event name cannot be longer that 100 characters")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Event date is required")]
        public DateTime Date {get; set;}
        
        [Required(ErrorMessage = "Location is rewuired")]
        public string Location {get; set;}
    }
}