using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VirtualReceptionist.Desktop.Models;
using VirtualReceptionist.Desktop.Repositories.MySQLConnection;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class GuestRepository
    {
        private readonly Database database;
        private readonly List<Guest> guests;

        public GuestRepository()
        {
            database = Database.GetInstance();
            guests = new List<Guest>();
        }

        private void UploadGuestsList()
        {
            const string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID";
            var dataTable = database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var guest = new Guest
                {
                    Id = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    DocumentNumber = row["DocumentNumber"].ToString(),
                    Citizenship = row["Citizenship"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]).ToString("yyyy-MM-dd"),
                    Country = row["CountryName"].ToString(),
                    ZipCode = row["ZipCode"].ToString(),
                    City = row["City"].ToString(),
                    Address = row["Address"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    EmailAddress = row["EmailAddress"].ToString()
                };

                guests.Add(guest);
            }
        }

        public List<Guest> GetGuests()
        {
            if (guests.Count == 0)
            {
                UploadGuestsList();
            }

            return guests;
        }

        public void Delete(int id)
        {
            var sql = $"DELETE FROM guest WHERE guest.ID = \"{id}\"";
            database.Dml(sql);
        }

        public void Update(Guest guest)
        {
            var sql =
                $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.DocumentNumber=\"{guest.DocumentNumber}\", guest.Citizenship=\"{guest.Citizenship}\", guest.BirthDate=\"{guest.BirthDate}\", guest.Country = (SELECT country.ID FROM country WHERE country.CountryName = \"{guest.Country}\"), guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.ID = \"{guest.Id}\"";
            database.Dml(sql);
        }

        public void Create(Guest guest)
        {
            var sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.DocumentNumber}\", \"{guest.Citizenship}\", \"{guest.BirthDate}\", (SELECT country.ID FROM country WHERE country.CountryName = \"{guest.Country}\"), \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\")";
            database.Dml(sql);
        }

        public int GetNextGuestID()
        {
            const string sql = "SELECT MAX(guest.ID) FROM guest";
            var maxId = database.ScalarDql(sql);

            int.TryParse(maxId, out var nextID);

            return nextID + 1;
        }

        public string[] GetGuestDataForBilling(string name)
        {
            var data = new string[5];

            if (guests.Count == 0)
            {
                UploadGuestsList();
            }

            foreach (var guest in guests.Where(guest => guest.Name == name))
            {
                data[0] = guest.Name;
                data[1] = guest.Country;
                data[2] = guest.City;
                data[3] = guest.ZipCode;
                data[4] = guest.Address;
            }

            return data;
        }
    }
}
