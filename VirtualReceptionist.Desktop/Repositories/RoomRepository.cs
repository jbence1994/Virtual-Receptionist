using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VirtualReceptionist.Desktop.Models;
using VirtualReceptionist.Desktop.Repositories.MySQLConnection;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class RoomRepository
    {
        private readonly Database database;
        private readonly List<Room> rooms;

        public RoomRepository()
        {
            database = Database.GetInstance();
            rooms = new List<Room>();
        }

        private void UploadRoomsList()
        {
            const string sql =
                "SELECT room.ID, room.Name, room.Number, billing_item.BillingItemName, room.Capacity FROM room, billing_item WHERE room.Category = billing_item.ID ORDER BY room.Number ASC";
            var dataTable = database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var room = new Room
                {
                    Id = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    Number = Convert.ToInt32(row["Number"]),
                    Category = row["BillingItemName"].ToString(),
                    Capacity = Convert.ToInt32(row["Capacity"])
                };

                rooms.Add(room);
            }
        }

        public List<Room> GetRooms()
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            return rooms;
        }

        public int GetRoomCapacity(int roomNumber)
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            return (from room in rooms where room.Number == roomNumber select room.Capacity).FirstOrDefault();
        }
    }
}
