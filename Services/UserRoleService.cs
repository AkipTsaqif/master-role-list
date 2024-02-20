using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepo _userRoleRepo;

        public UserRoleService(IUserRoleRepo userRoleRepo)
        {
            _userRoleRepo = userRoleRepo;
        }

        public async Task<object> GetUserRolesAsync()
        {
            return await _userRoleRepo.GetUserRolesAsync();
        }

        public async Task<object> GetUserRoleByNikAsync(string nik)
        {
            return await _userRoleRepo.GetUserRoleByNikAsync(nik);
        }
    }
}
