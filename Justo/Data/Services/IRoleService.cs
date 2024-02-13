using Justo.Models.Users;

namespace Justo.Data.Services
{
    public interface IRoleService
    {
        Task<List<Role>> GetRoles();
    }
}
