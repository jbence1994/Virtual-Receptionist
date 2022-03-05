namespace VirtualReceptionist.Desktop.Models
{
    public class Accomodation
    {
        private static Accomodation _accommodationInstance;

        private Accomodation()
        {
        }

        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public string VatNumber { get; set; }
        public string Headquarters { get; set; }
        public string Site { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AccommodationId { get; set; }

        public string Password { get; set; }

        public static Accomodation GetAccommodation()
        {
            if (_accommodationInstance == null)
            {
                return _accommodationInstance = new Accomodation();
            }

            return _accommodationInstance;
        }
    }
}
