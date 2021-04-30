using Domain.Models;

namespace Domain.Interface.Services
{
    public interface IUsuarioService:IGenericService<Usuario>
    {
        void ChangePassword(string OldPassword,string NewPassword);
    }
}
