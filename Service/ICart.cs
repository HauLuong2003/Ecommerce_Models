
using Ecommerce_Models.Model.Entity;
using Ecommerce_Models.Model.Request;
using Ecommerce_Models.Response;

namespace Ecommerce_Models.Service
{
    public interface ICart
    {
        Task<ServiceResponse> AddItem(CartItemDto cartItemDto);
        Task<ServiceResponse> AddToCart(int userId, CartItemDto cartItemDto);
        Task<CartItem> UpdateQty(UpdateCartDto updateCartDto);
        Task<bool> DeleteItem(string cartId,int id);
        Task<List<CartItem>> GetItemByUser(int userId,string cartId);
        Task<List<CartItem>> GetItem(string cartId);
        Task ClearCart(string  cartId);
    }
}
