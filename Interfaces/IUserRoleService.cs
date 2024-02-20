using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IUserRoleService
    {
        Task<object> GetUserRolesAsync();
        Task<object> GetUserRoleByNikAsync(string id);
    }
}
