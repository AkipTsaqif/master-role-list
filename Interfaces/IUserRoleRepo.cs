using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IUserRoleRepo
    {
        Task<object> GetUserRolesAsync();
        Task<object> GetUserRoleByNikAsync(string id);
    }
}
