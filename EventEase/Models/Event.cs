using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Event name is required.")]
        [StringLength(150)]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Event date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }

        public int? EventTypeId { get; set; }
        public EventType? EventType { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}