namespace VirtualReceptionist.Desktop.Models
{
    public class BillingItemCategory
    {
        public BillingItemCategory(
            string name,
            double vat,
            string unit
        )
        {
            Name = name;
            Vat = vat;
            Unit = unit;
        }

        public string Name { get; set; }
        public double Vat { get; set; }
        public string Unit { get; set; }
    }
}
