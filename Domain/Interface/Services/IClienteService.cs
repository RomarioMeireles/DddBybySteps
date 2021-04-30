using Domain.Models;

namespace Domain.Interface.Services
{
    public interface IClienteService:IGenericService<Cliente>
    {
        Cliente GetByEmail(string Email);
    }
}
