using Domain.Models;

namespace Domain.Interface.Repositories
{
    public interface IUsuarioRepository:IGenericRepository<Usuario>
    {
        void ChangePassword(string OldPassword,string NewPassword);
    }
}
