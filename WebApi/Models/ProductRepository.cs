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
        return connection.Execute("INSERT INTO Product(ProductName, Description, Quantity, Price, ImageUrl) VALUES (@ProductName, @Description, @Quantity, @Price, @ImageUrl)",obj);
    }
}