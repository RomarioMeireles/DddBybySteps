using Domain.Models;

namespace Domain.Interface.Repositories
{
    public interface IClienteRepository:IGenericRepository<Cliente>
    {
        Cliente GetByEmail(string Email);
    }
}
