using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Services
{
    public class SaveUserRoleService : ISaveUserRoleService
    {
        private readonly ISaveUserRoleRepo _saveUserRoleRepo;

        public SaveUserRoleService(ISaveUserRoleRepo saveUserRoleRepo)
        {
            _saveUserRoleRepo = saveUserRoleRepo;
        }

        public async Task<bool> SaveUserRole(EbatchUserroleidT userRole)
        {
            return await _saveUserRoleRepo.SaveUserRole(userRole);
        }
    }
}
