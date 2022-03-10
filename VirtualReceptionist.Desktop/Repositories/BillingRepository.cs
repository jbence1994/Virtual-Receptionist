using System;
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
            const string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            var dataTable = Database.Dql(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                var billingItemCategory = new BillingItemCategory
                {
                    Name = row["BillingItemCategoryName"].ToString(),
                    Vat = Convert.ToDouble(row["VAT"].ToString()),
                    Unit = row["Unit"].ToString()
                };

                var billingItem = new BillingItem
                {
                    Name = row["BillingItemName"].ToString(),
                    Category = billingItemCategory,
                    Price = Convert.ToDouble(row["Price"].ToString())
                };

                billingItems.Add(billingItem);
            }
        }

        public IEnumerable<BillingItem> GetBillingItems()
        {
            if (billingItems.Count == 0)
            {
                UploadBillingItemsList();
            }

            return billingItems;
        }

        public double CountDiscountPrice(double itemPrice, double footPercent)
        {
            var difference = (itemPrice * footPercent) / 100;
            return itemPrice - difference;
        }

        public double CountTotalPrice(double price, int quantity)
        {
            return price * quantity;
        }

        public void SetBookingAsPaid(Booking booking)
        {
            var sql = $"UPDATE booking SET booking.Paid = 1 WHERE booking.ID = \"{booking.Id}\"";
            Database.Dml(sql);
        }
    }
}
