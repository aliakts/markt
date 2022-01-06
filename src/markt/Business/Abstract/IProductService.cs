using markt.Entities;
using markt.Models;
using markt.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markt.Business.Abstract
{
    public interface IProductService
    {
        Task<int> AddAsync(ProductDto entity);
        Task<WebApiResponse> UpdateAsync(int? productId, ProductDto entity);
        Task<WebApiResponse> DeleteAsync(int? productId);
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetByIdAsync(int? productId);
    }
}