using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Client name is required.")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Booking date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime BookingDate { get; set; }

        [Required]
        public int EventId { get; set; }
        public Event? Event { get; set; }

        [Required]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}