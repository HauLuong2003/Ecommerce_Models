
using Ecommerce_Models.Model.Request;
using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface IUserAccount
    {
        Task<ServiceResponse> Register(UserRegisterRequest request);
        Task<ServiceResponse> Login(LoginRequest request);
        Task<ServiceResponse> ForgotPassword(string email);
        Task<ServiceResponse> ResetPassword(ResetPassword resetPassword);
        Task<ServiceResponse> Verify(string token);
    }
}
