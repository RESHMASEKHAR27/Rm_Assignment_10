using Rm_Assignment_10.Models;

namespace Rm_Assignment_10.Repository
{
    public class OrderRepository : IOrderRepository
    {
        List<Product> productList = ProductRepository.products;
        List<Order> orders = new List<Order>();

        //DeleteOrder
        public void DeleteOrder(int id)
        {
            foreach (Order order in orders)
            {
                if (order.OrderId == id)
                {
                    orders.Remove(order);
                    return;
                }
            }
        }
        //GetOrders
        public List<Order> GetOrders()
        {
            return orders;
        }
        //OrderProduct
        public string OrderProduct(Order order)
        {
            Product? o = (from pr in productList
                          where order.ProductId == pr.ProductID
                          select pr).SingleOrDefault();

            if (o == null)
            {
                return "No products available";
            }
            else
            {
                order.TotalPrice = o.Price * order.Quantity;
                orders.Add(order);
                return ("Order placed...");
            }
        }
    }
}
