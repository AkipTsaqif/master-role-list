using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface ISaveUserRoleRepo
    {
        Task<bool> SaveUserRole(EbatchUserroleidT userRole);
    }
}
