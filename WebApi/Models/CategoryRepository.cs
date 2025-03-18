using System.Data;
using Dapper;

namespace WebApi.Models;
public class CategoryRepository : BaseRepository
{
        public CategoryRepository(IDbConnection connection) : base(connection)
        {
        }
    

        public IEnumerable<Category> GetCategories()
    {
        return connection.Query<Category>("SELECT * FROM Category");
    }

    public Category? GetCategory(short id)
    {
        return connection.QuerySingleOrDefault<Category>("SELECT * FROM Category WHERE CategoryId = @Id", new { Id = id });
    }

    public int Add(Category obj)
    {
        return connection.Execute("INSERT INTO Category (CategoryName) VALUES (@CategoryName)", obj);
    }

    public int Delete(short id)
    {
        return connection.Execute("DELETE FROM Category WHERE CategoryId = @Id", new { Id = id });
    }

    public int Edit(Category obj)
    {
        return connection.Execute("UPDATE Category SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId", obj);
    }

    public int Count()
    {
        return connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Category");
    }
    
}

