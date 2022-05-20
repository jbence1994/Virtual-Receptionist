namespace VirtualReceptionist.Desktop.Models
{
    public class Booking
    {
        public Booking(
            int id,
            Guest guest,
            Room room,
            int numberOfGuests,
            string arrivalDate,
            string departureDate,
            bool paid)
        {
            Id = id;
            Guest = guest;
            Room = room;
            NumberOfGuests = numberOfGuests;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            Paid = paid;
        }

        public Booking(
            int id,
            Guest guest,
            Room room,
            int numberOfGuests,
            string arrivalDate,
            string departureDate
        )
        {
            Id = id;
            Guest = guest;
            Room = room;
            NumberOfGuests = numberOfGuests;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
        }

        public Booking(
            Guest guest,
            Room room,
            int numberOfGuests,
            string arrivalDate,
            string departureDate,
            bool paid
        )
        {
            Guest = guest;
            Room = room;
            NumberOfGuests = numberOfGuests;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            Paid = paid;
        }

        public Booking()
        {
        }

        public int Id { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public int NumberOfGuests { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public bool Paid { get; set; }
    }
}
