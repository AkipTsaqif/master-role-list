using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface ISaveUserRoleService
    {
        Task<bool> SaveUserRole(EbatchUserroleidT userRole);
    }
}
