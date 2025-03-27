using System.Data;
using Dapper;
using WebApi.Services;

namespace WebApi.Models
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IDbConnection connection) : base(connection)
        {
        }
        public int Add(RegisterModel obj)
        {
            return connection.Execute("AddMember", new
            {
                obj.MemberId,
                obj.GivenName,
                obj.Surname,
                obj.Email,
                Password = Helper.Hash(obj.Password)
            }, commandType: CommandType.StoredProcedure);
        }
    }
}
