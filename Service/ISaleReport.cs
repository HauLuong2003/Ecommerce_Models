using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface ISaleReport
    {
        Task<List<ProductInventory>> productInventory();
        Task<List<Revenue>> GetRevenueByDay(int day,int month, int year);
        Task<List<Revenue>> GetRevenueByMonth(int? month,int year);
    }
}
