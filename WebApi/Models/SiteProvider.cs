namespace WebApi.Models;

public class SiteProvider(IConfiguration configuration) : BaseProvider(configuration)
{
    CategoryRepository? category;

    public CategoryRepository Category => category ??= new CategoryRepository(Connection);

     ProductRepository? product;

    public ProductRepository Product => product ??= new ProductRepository(Connection);

    MemberRepository? member;
    public MemberRepository Member => member??= new MemberRepository(Connection);
}
