using System.Collections;
using System.Data;
using Dapper;
using Microsoft.AspNetCore.Identity;

namespace WebApi.Models;

public class ProductRepository : BaseRepository
{
    public ProductRepository(IDbConnection connection) : base(connection)
    {
    }

    public IEnumerable<Product> GetProducts()
    {
        return connection.Query<Product>("SELECT * FROM Product");
    }

    public int Add(Product obj)
    {
       return connection.Execute("AddProduct", obj, commandType: CommandType.StoredProcedure);
    }
    public IEnumerable<Product> GetProducts(int page, int size)
    {
        return connection.Query<Product>("GetProducts", new { Index = (page - 1) * size, Size = size }, commandType: CommandType.StoredProcedure);
    }
    public int Count()
    {
       return 0;
    }
}