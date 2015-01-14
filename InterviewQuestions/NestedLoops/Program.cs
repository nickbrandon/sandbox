using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace NestedLoops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var orders = new List<Order>();

            for (int i = 0; i < 10; i++)
            {
                var order = new Order();
                order.Items = new List<Item>();
                var myItem = new Item
                {
                    Quantity = i,
                };
                order.Items.Add(myItem);

                orders.Add(order);
            }

            int theSum = NestedLooper(orders);
            Console.WriteLine(theSum);
        }


        public static int NestedLooper(List<Order> orders)
        {
            int sum = 0;
            foreach (Order o in orders)
            {
                //foreach loop
                foreach (Item item in o.Items)
                {
                    sum += item.Quantity;
                }
                //linq to do the above foreach loop
                //sum += o.Items.Sum(item => item.Quantity);
            }

            



            return sum;
        }

        public class Item
        {
            public int Quantity { get; set; }
            public string Name { get; set; }
        }

        public class Order
        {
            public List<Item> Items { get; set; }
        }
    }
}