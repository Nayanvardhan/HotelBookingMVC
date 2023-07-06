namespace FirstMVC.Models
{
    public class HotelBooking
    {

        public int Id { get; set; }

        public string GuestName { get; set; } = String.Empty;

        public DateTime DateStart { get; set; }

        public DateTime EndDate { get; set; }
    }
}
