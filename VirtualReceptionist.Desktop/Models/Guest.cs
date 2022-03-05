namespace VirtualReceptionist.Desktop.Models
{
    public class Guest
    {
        public Guest(
            int id,
            string name,
            string documentNumber,
            string citizenship,
            string birthDate,
            string country,
            string zipCode,
            string city,
            string address,
            string phoneNumber,
            string emailAddress
        )
        {
            Id = id;
            Name = name;
            DocumentNumber = documentNumber;
            Citizenship = citizenship;
            BirthDate = birthDate;
            Country = country;
            ZipCode = zipCode;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        public Guest(
            string name,
            string documentNumber,
            string citizenship,
            string birthDate,
            string country,
            string zipCode,
            string city,
            string address,
            string phoneNumber,
            string emailAddress
        )
        {
            Name = name;
            DocumentNumber = documentNumber;
            Citizenship = citizenship;
            BirthDate = birthDate;
            Country = country;
            ZipCode = zipCode;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        public Guest()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public string Citizenship { get; set; }
        public string BirthDate { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
