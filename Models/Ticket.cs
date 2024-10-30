namespace Ticket_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string PassengerName { get; set; }
        public string PassengerEmail { get; set; }
        public DateTime BookingDate { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public string Status { get; set; }
    }
}
