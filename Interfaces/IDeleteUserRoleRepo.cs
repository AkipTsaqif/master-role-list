using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IDeleteUserRoleRepo
    {
        public Task<bool> DeleteUserRole(EbatchUserroleidT userRole);
    }
}
