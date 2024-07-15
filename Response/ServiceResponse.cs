using Ecommerce_Models.Model.Entity;

namespace Ecommerce_Models.Response
{
    public record class ServiceResponse (bool Flag,string Message);

    public record class ProductServiceResponse(bool Flag,Product product);
}
