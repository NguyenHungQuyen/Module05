namespace WebApp.Models;

public class SiteProvider
{
    IConfiguration configuration;

    public SiteProvider(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    CategoryRepository? category;

    public CategoryRepository Category => category ??= new CategoryRepository(configuration);
    ProductRepository? product;

    public ProductRepository Product => product ??= new ProductRepository(configuration);
}
