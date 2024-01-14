using Rm_Assignment_10.Models;

namespace Rm_Assignment_10.Repository
{
    public interface IOrderRepository
    {
        string OrderProduct(Order order);
        List<Order> GetOrders();
        void DeleteOrder(int id);
    }
}
