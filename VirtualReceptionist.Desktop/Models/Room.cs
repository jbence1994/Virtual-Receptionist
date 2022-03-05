namespace VirtualReceptionist.Desktop.Models
{
    public class Room
    {
        public Room(
            int id,
            string name,
            int number,
            string category,
            int capacity
        )
        {
            Id = id;
            Name = name;
            Number = number;
            Category = category;
            Capacity = capacity;
        }

        public Room()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Category { get; set; }
        public int Capacity { get; set; }
    }
}
