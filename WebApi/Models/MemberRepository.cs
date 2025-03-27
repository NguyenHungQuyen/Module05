using System.Data;
using Dapper;
using WebApi.Services;

namespace WebApi.Models
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IDbConnection connection) : base(connection) { }
    }
}
