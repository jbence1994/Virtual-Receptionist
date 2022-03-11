using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VirtualReceptionist.Desktop.Models;
using VirtualReceptionist.Desktop.Repositories.MySQLConnection;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class BookingRepository
    {
        private readonly Database database;
        private readonly List<Booking> bookings;

        public BookingRepository()
        {
            database = Database.GetInstance();
            bookings = new List<Booking>();
        }

        private void UploadBookingsList()
        {
            const string sql =
                "SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.Paid FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID";
            var dataTable = database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var booking = new Booking
                {
                    Id = Convert.ToInt32(row["ID"]),
                    Guest = new Guest
                    {
                        Name = row["Name"].ToString()
                    },
                    Room = new Room
                    {
                        Number = Convert.ToInt32(row["Number"])
                    },
                    NumberOfGuests = Convert.ToInt32(row["NumberOfGuests"]),
                    ArrivalDate = Convert.ToDateTime(row["ArrivalDate"]).ToString("yyyy-MM-dd"),
                    DepartureDate = Convert.ToDateTime(row["DepartureDate"]).ToString("yyyy-MM-dd"),
                    Paid = Convert.ToBoolean(row["Paid"])
                };

                bookings.Add(booking);
            }
        }

        public List<Booking> GetBookings()
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            return bookings;
        }

        public void Create(Booking booking)
        {
            var sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate, Paid) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), \"{booking.NumberOfGuests}\", \"{booking.ArrivalDate}\", \"{booking.DepartureDate}\", \"{booking.Paid}\");";
            database.Dml(sql);
        }

        public void Delete(int id)
        {
            var sql = $"DELETE FROM booking WHERE booking.ID = \"{id}\"";
            database.Dml(sql);
        }

        public void Update(Booking booking)
        {
            var sql =
                $"UPDATE booking SET booking.GuestID = (SELECT guest.ID FROM guest WHERE guest.Name = \"{booking.Guest.Name}\"), booking.RoomID = (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), NumberOfGuests = \"{booking.NumberOfGuests}\", ArrivalDate = \"{booking.ArrivalDate}\", DepartureDate = \"{booking.DepartureDate}\" WHERE booking.ID = \"{booking.Id}\"";
            database.Dml(sql);
        }

        public IEnumerable<Booking> GetGuestBookingsByArrivalDate(string arrivalDate)
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => booking.ArrivalDate == arrivalDate).ToList();
        }

        public IEnumerable<Booking> GetGuestBookingsByDepartureDate(string departureDate)
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => booking.DepartureDate == departureDate).ToList();
        }

        public IEnumerable<Booking> GetBookingsNotPaid()
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => !booking.Paid).ToList();
        }
    }
}
