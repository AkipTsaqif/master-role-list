using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IDeleteUserRoleService
    {
        public Task<bool> DeleteUserRole(EbatchUserroleidT userRole);
    }
}
