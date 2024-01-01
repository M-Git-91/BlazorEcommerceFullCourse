using BlazorEcommerce.Shared.DTO;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
        Task<ServiceResponse<List<Product>>> GetAdminProductsAsync();
        Task<ServiceResponse<Product>> CreateProduct(Product product);
        Task<ServiceResponse<Product>> UpdateProductAsync(Product product);
        Task<ServiceResponse<bool>> DeleteProductAsync(int productId);

    }
}
