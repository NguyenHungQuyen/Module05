
namespace WebApp.Models;

public class MemberRepository : BaseRepository
{
    public MemberRepository(IConfiguration configuration) : base(configuration)
    {
    }
    public int Add(RegisterModel obj)
    {
        return 0;
    }
}
