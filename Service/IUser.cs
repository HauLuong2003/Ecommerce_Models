using Ecommerce_Models.Model.Entity;
using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface IUser
    {
        Task<User> Update(int userId,User user);
        Task<ServiceResponse> Delete(int id);
        Task<User> GetUserById(int id);
        Task<User> GetUserByPhone(string phone);
        Task<List<User>> GetUserByName(string name);
        Task<List<User>> GetAllUser();
    }
}
