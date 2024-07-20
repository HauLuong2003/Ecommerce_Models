using Ecommerce_Models.Model.Entity;
using Ecommerce_Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Models.Service
{
    public interface IReview
    {
        Task<ServiceResponse> AddReview(int userId,Review review);
        Task<ServiceResponse> UpdateReview(int id,Review review);
        Task<Review> GetReview(int id);
        Task<List<Review>> GetAllReviews(); 
        Task<ServiceResponse> DeleteReview(int id);

    }
}
