namespace WebApp.Models;

public abstract class BaseRepository
{
    protected Uri uri;

    public BaseRepository(IConfiguration configuration)
    {
        uri = new Uri(configuration["ApiUrl"] ?? throw new Exception("Not found ApiUrl"));
    }
}
