using SqlWebApp.Models;

namespace WebAppWithSQLDB.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
