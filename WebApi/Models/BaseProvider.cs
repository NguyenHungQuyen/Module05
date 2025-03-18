using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApi.Models;

public abstract class BaseProvider
{
    IDbConnection? connection;
    string connectionString;

    public BaseProvider(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("Store") ?? throw new Exception("Not found Store");
    }

    protected IDbConnection Connection => connection ??= new SqlConnection(connectionString);
}
