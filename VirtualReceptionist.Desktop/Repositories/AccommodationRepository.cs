using System.Data;
using virtual_receptionist.Controllers.Exceptions;
using VirtualReceptionist.Desktop.Models;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class AccommodationRepository : Repository
    {
        private void SetAccommodation()
        {
            const string sql =
                "SELECT accomodation.ID, accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";
            var dataTable = database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var accommodationId = row["AccomodationID"].ToString();
                var password = row["Password"].ToString();

                var accommodation = Accommodation.GetAccommodation();
                accommodation.Name = row["AccomodationName"].ToString();
                accommodation.CompanyName = row["CompanyName"].ToString();
                accommodation.Contact = row["Contact"].ToString();
                accommodation.VatNumber = row["VATNumber"].ToString();
                accommodation.Headquarters = row["Headquarters"].ToString();
                accommodation.Site = row["Site"].ToString();
                accommodation.PhoneNumber = row["PhoneNumber"].ToString();
                accommodation.EmailAddress = row["EmailAddress"].ToString();
                accommodation.AccommodationId = accommodationId;
                accommodation.Password = password;
            }
        }

        public Accommodation GetAccommodation()
        {
            var accommodation = Accommodation.GetAccommodation();
            SetAccommodation();
            return accommodation;
        }

        public bool Authentication(string accommodationId, string password)
        {
            database.SetConnection();

            var accommodation = GetAccommodation();

            return accommodation.AccommodationId == accommodationId && accommodation.Password == password;
        }
    }
}
