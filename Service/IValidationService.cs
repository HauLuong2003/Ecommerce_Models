using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface IValidationService
    {
        Task<ServiceResponse> CheckProductNameAsync(string name);
        Task<ServiceResponse> CheckBrandNameAsync(string name);
        public bool ProductExists(int id);
       
    }
}
