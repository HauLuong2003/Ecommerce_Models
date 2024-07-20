using Ecommerce_Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Models.Service
{
    public interface IImage
    {
        Task<string> AddImage(MultipartFormDataContent Addimage);

    }
}
