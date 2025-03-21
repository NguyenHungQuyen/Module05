namespace WebApp.Models
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration) { }

        public async Task<IEnumerable<Product>?> GetProductsAsync()
        {
            using (HttpClient client = new HttpClient { BaseAddress = uri })
            {
                return await client.GetFromJsonAsync<IEnumerable<Product>>("/api/product");
            }
        }
    }
}
