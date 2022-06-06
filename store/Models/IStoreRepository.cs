using System.Linq;
namespace store.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
