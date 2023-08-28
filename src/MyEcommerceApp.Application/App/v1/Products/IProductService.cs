using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Products
{
    public interface IProductService : IApplicationService
    {
        Task CreateAsync();
    }
}
