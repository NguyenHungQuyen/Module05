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

    public async Task<int> AddAsync(Category obj){
    using(HttpClient client = new HttpClient{ BaseAddress = uri }){
        HttpResponseMessage message = await client.PostAsJsonAsync("/api/category", obj);
        if(message.IsSuccessStatusCode){
            return await message.Content.ReadFromJsonAsync<int>();
        }
    }
    return -1;
}

}
