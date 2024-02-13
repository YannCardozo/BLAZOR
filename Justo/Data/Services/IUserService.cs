using Justo.Models.Users;

namespace Justo.Data.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid Id);

        // retorna true ou false para saber se deletou determinado usuario
        Task<bool> DeleteUser(Guid Id);
        Task<bool> UpdateUserRole(Guid Id, User user);
    }
}
