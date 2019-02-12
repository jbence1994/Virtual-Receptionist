﻿using System;
using System.Data;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository
    {
        #region Foglalási napló modul

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobakiadásokat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadBookingsList()
        {
            string sql =
                "SELECT guest.Name, room.Number, reservation.NumberOfGuests, reservation.ArrivalDate, reservation.DepartureDate FROM reservation, guest, room WHERE reservation.GuestID = guest.ID AND reservation.RoomID = room.ID ORDER BY reservation.ArrivalDate ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                //Guest guest = new PrivateGuest()
                //{
                //    Name = row["Name"].ToString()
                //};

                Room room = new Room
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

                //Booking bookingInstance = new Booking(guest, room, numberOfGuests, arrival, departure);
                //bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobákat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        private void UploadRoomsList()
        {
            string sql =
                "SELECT room.Name, room.Number, room_category.CategoryName, room.Capacity FROM room, room_category WHERE room.Category = room_category.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["CategoryName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                Room roomInstance = new Room(name, number, category, capacity);
                rooms.Add(roomInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szobakiadás adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public DataTable GetBookings()
        {
            if (bookings.Count == 0)
            {
                UploadBookingsList();
            }

            DataTable bookingsDataTable = new DataTable();
            bookingsDataTable.Columns.Add("GuestName", typeof(Guest));
            bookingsDataTable.Columns.Add("RoomNumber", typeof(Room));
            bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookings)
            {
                bookingsDataTable.Rows.Add(booking.Guest, booking.Room, booking.NumberOfGuests,
                    booking.Arrival, booking.Departure);
            }

            return bookingsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public DataTable GetRooms()
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            DataTable roomsDataTable = new DataTable();
            roomsDataTable.Columns.Add("Name", typeof(string));
            roomsDataTable.Columns.Add("Number", typeof(int));
            roomsDataTable.Columns.Add("CategoryName", typeof(string));
            roomsDataTable.Columns.Add("Capacity", typeof(int));

            foreach (Room room in rooms)
            {
                roomsDataTable.Rows.Add(room.Name, room.Number, room.Category, room.Capacity);
            }

            return roomsDataTable;
        }

        #endregion
    }
}