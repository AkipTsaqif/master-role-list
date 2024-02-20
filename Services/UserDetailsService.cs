using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Services
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepo _userDetailsRepo;

        public UserDetailsService(IUserDetailsRepo userDetailsRepo)
        {
            _userDetailsRepo = userDetailsRepo;
        }

        public async Task<List<MUserAllHierarki>> GetUserDetails()
        {
            try
            {
                return await _userDetailsRepo.GetUserDetails();
            } catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<EbatchRoleidM>> GetRoleDetails()
        {
            try
            {
                return await _userDetailsRepo.GetRoleDetails();
            } catch (Exception ex)
            {
                throw;
            }
        }
    }
}
