using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Services
{
    public class DeleteUserRoleService : IDeleteUserRoleService
    {
        private readonly IDeleteUserRoleRepo _deleteUserRoleRepo;

        public DeleteUserRoleService(IDeleteUserRoleRepo deleteUserRoleRepo)
        {
            _deleteUserRoleRepo = deleteUserRoleRepo;
        }

        public async Task<bool> DeleteUserRole(EbatchUserroleidT userRole)
        {
            return await _deleteUserRoleRepo.DeleteUserRole(userRole);
        }
    }
}
