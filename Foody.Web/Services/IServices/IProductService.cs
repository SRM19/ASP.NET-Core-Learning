using Foody.Web.Models;

namespace Foody.Web.Services.IServices
{
    public interface IProductService 
    {
        Task<T> GetallProductsAsync<T>();

        Task<T> GetProductByIdAsync<T>(int id);

        Task<T> CreateProductAsync<T>(ProductsDto product);

        Task<T> UpdateProductAsync<T>(ProductsDto product);

        Task<T> DeleteProductAsync<T>(int id);
    }
}
