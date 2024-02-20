using MasterRoleList.Models;

namespace MasterRoleList.Interfaces
{
    public interface IUserDetailsRepo
    {
        public Task<List<MUserAllHierarki>> GetUserDetails();
        public Task<List<EbatchRoleidM>> GetRoleDetails();
    }
}
