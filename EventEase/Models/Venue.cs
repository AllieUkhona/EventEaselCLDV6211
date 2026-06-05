using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Venue name is required.")]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Range(1, 100000, ErrorMessage = "Capacity must be between 1 and 100,000.")]
        public int Capacity { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Event>? Events { get; set; }
    }
}