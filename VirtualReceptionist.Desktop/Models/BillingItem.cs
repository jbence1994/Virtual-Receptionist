namespace VirtualReceptionist.Desktop.Models
{
    public class BillingItem
    {
        public BillingItem(
            string name,
            BillingItemCategory category,
            double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public string Name { get; set; }
        public BillingItemCategory Category { get; set; }
        public double Price { get; set; }
    }
}
