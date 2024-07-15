using Ecommerce_Models.Model.Entity;
using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface IOrderManage
    {
        Task<List<Oder>> GetOrder();
        Task<List<Oder>> GetOderStatus(int status);
        Task<ServiceResponse>UpdateOrderStatus(int orderId, int status);
        Task<ServiceResponse> DeleteOrder(int orderId);
        Task<Oder>AddOrder(Oder order);
        Task<List<OrderStatus>> OrderStatus();
    }
}
