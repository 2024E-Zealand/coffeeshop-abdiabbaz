using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        public int OrderId { get; set; }
        public string BaristaName { get; set; }
        public string CustomerName { get; set; }
        public int TableId { get; set; } 
        public List<Coffee> OrderedCoffees { get; set; }

        
        public Order(int orderId, string baristaName, string customerName, int tableId)
        {
            OrderId = orderId;
            BaristaName = baristaName;
            CustomerName = customerName;
            TableId = tableId;
            OrderedCoffees = new List<Coffee>();

        }


        public int CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (var coffee in OrderedCoffees)
            {
                totalPrice += coffee.Price(); 
            }

            return totalPrice;
        }

        public int CalculateTotalItems()
        {
            return OrderedCoffees.Count;
        }

        public int CalculateTotalDiscount()
        {
            int totalDiscount = 0;

            foreach (var discount in OrderedCoffees)
            {
                totalDiscount += discount.Discount;
            }

            return totalDiscount;
        }



    }

}
