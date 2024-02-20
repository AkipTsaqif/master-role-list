using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IUserDetailsService
    {
        public Task<List<MUserAllHierarki>> GetUserDetails();
        public Task<List<EbatchRoleidM>> GetRoleDetails();
    }
}
