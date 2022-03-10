using System.Collections.Generic;
using System.Data;
using VirtualReceptionist.Desktop.Models;

namespace VirtualReceptionist.Desktop.Repositories
{
    public class BillingRepository : Repository
    {
        private readonly List<BillingItem> billingItems;

        public BillingRepository()
        {
            billingItems = new List<BillingItem>();
        }

        private void UploadBillingItemsList()
        {
            string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            DataTable dt = Database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["BillingItemName"].ToString();
                string categoryName = row["BillingItemCategoryName"].ToString();
                double vat = double.Parse(row["VAT"].ToString());
                string unit = row["Unit"].ToString();
                double price = double.Parse(row["Price"].ToString());

                BillingItemCategory billingItemCategoryInstance = new BillingItemCategory(categoryName, vat, unit);
                BillingItem billingItemInstance = new BillingItem(name, billingItemCategoryInstance, price);
                billingItems.Add(billingItemInstance);
            }
        }

        public List<BillingItem> GetBillingItems()
        {
            if (billingItems.Count == 0)
            {
                UploadBillingItemsList();
            }

            return billingItems;
        }

        public double CountDiscountPrice(double itemPrice, double footPercent)
        {
            double difference = (itemPrice * footPercent) / 100;
            return itemPrice - difference;
        }

        public double CountTotalPrice(double price, int quantity)
        {
            return price * quantity;
        }

        public void SetBookingAsPaid(Booking booking)
        {
            string sql = $"UPDATE booking SET booking.Paid = 1 WHERE booking.ID = \"{booking.Id}\"";
            Database.Dml(sql);
        }
    }
}
