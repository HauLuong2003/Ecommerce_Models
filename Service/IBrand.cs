using Ecommerce_Models.Model.Entity;
using Ecommerce_Models.Response;
namespace Ecommerce_Models.Service
{
    public interface IBrand
    {
        Task<List<Brand>> GetAllBrands();
        Task<Brand> GetBrandById(int id);
        Task<Brand> UpdateBrand(int id,Brand brand);
        Task DeleteBrand(int id);
        Task<ServiceResponse> AddBrand(Brand brand);
       
    }
}
