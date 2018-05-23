using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DxSample.Service.Models {
    public static class DataContext {
        private static readonly List<Customer> ListCustomers;
        private static readonly List<Order> ListOrders;
        private static int CustomersCounter;
        private static int OrdersCounter;
        private static readonly object Sync = new object();

        static DataContext() {
            DataContext.ListCustomers = new List<Customer>();
            DataContext.ListOrders = new List<Order>();
            DataContext.CustomersCounter = 1;
            DataContext.OrdersCounter = 1;
            DataContext.AddCustomer("John");
            DataContext.AddCustomer("Bob");
            DataContext.AddOrder("Chai", 1);
            DataContext.AddOrder("Chang", 1);
            DataContext.AddOrder("Queso Caprale", 2);
        }

        public static IQueryable<Customer> Customers {
            get { return DataContext.ListCustomers.AsQueryable(); }
        }

        public static IQueryable<Order> Orders {
            get { return DataContext.ListOrders.AsQueryable(); }
        }

        public static Task<Customer> AddCustomer(string name) {
            return Task.Run<Customer>(() => {
                lock (DataContext.Sync) {
                    Customer result = new Customer() { ID = DataContext.CustomersCounter++, Name = name };
                    DataContext.ListCustomers.Add(result);
                    return result;
                }
            });
        }

        public static Task<Order> AddOrder(string name, int customerID) {
            return Task.Run<Order>(() => {
                lock (DataContext.Sync) {
                    Order result = new Order() { ID = DataContext.OrdersCounter++, Name = name, CustomerID = customerID };
                    DataContext.ListOrders.Add(result);
                    return result;
                }
            });
        }

        public static Task<Customer> FindCustomerAsync(int key) {
            return Task.Run<Customer>(() => DataContext.Customers.SingleOrDefault(c => c.ID == key));
        }

        public static Task<Order> FindOrderAsync(int key) {
            return Task.Run<Order>(() => DataContext.Orders.SingleOrDefault(o => o.ID == key));
        }

        public static Task UpdateCustomer(Customer customer) {
            return Task.Run(() => {
                Customer original = DataContext.Customers.Single(c => c.ID == customer.ID);
                int index = DataContext.ListCustomers.IndexOf(original);
                DataContext.ListCustomers[index] = customer;
            });
        }

        public static Task UpdateOrder(Order order) {
            return Task.Run(() => {
                Order original = DataContext.Orders.Single(o => o.ID == order.ID);
                int index = DataContext.ListOrders.IndexOf(original);
                DataContext.ListOrders[index] = order;
            });
        }

        public static Task RemoveCustomer(Customer customer) {
            return Task.Run(() => DataContext.ListCustomers.Remove(customer));
        }

        public static Task RemoveOrder(Order order) {
            return Task.Run(() => DataContext.ListOrders.Remove(order));
        }
    }
}