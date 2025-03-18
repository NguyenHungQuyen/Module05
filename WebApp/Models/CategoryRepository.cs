namespace WebApp.Models;

public class CategoryRepository : BaseRepository
{
    public CategoryRepository(IConfiguration configuration) : base(configuration)
    {
    }

    public async Task<IEnumerable<Category>?> GetCategoriesAsync()
    {
        using(HttpClient client = new HttpClient { BaseAddress = uri })
        {
            return await client.GetFromJsonAsync<IEnumerable<Category>>("/api/category");
        }
    }
}
