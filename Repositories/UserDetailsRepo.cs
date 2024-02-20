using MasterRoleList.Interfaces;
using MasterRoleList.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterRoleList.Repositories
{
    public class UserDetailsRepo : IUserDetailsRepo
    {
        public readonly Master_ApprovalContext _approvalContext;
        public readonly IT_SupportContext _supportContext;

        public UserDetailsRepo(Master_ApprovalContext approvalContext, IT_SupportContext supportContext)
        {
            _approvalContext = approvalContext;
            _supportContext = supportContext;
        }

        public async Task<List<MUserAllHierarki>> GetUserDetails()
        {
            try
            {
                return await _supportContext.MUserAllHierarkis.OrderBy(u => u.Empname).GroupBy(u => u.Empid).Select(u => u.First()).ToListAsync();
            } catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<EbatchRoleidM>> GetRoleDetails()
        {
            try
            {

                return await _approvalContext.EbatchRoleidMs.Where(e => e.Isactive ?? false && e.Type == "").OrderBy(e => e.Roledescription).ToListAsync();
            } catch (Exception ex)
            {
                throw;
            }
        }
    }
}
