using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Repositories
{
    public class UserRoleRepo : IUserRoleRepo
    {
        public readonly Master_ApprovalContext _approvalContext;
        public readonly IT_SupportContext _supportContext;

        public UserRoleRepo(Master_ApprovalContext context, IT_SupportContext supportContext)
        {
            _approvalContext = context;
            _supportContext = supportContext;
        }

        public async Task<object> GetUserRolesAsync()
        {
            try
            {
                var ebatch = (from t in _approvalContext.EbatchUserroleidTs
                              join m in _approvalContext.EbatchRoleidMs
                              on t.RoleidFk equals m.Roleid
                              select new
                              {
                                  t,
                                  m
                              }).ToList();

                var support = _supportContext.MUserAllApps.ToList();

                var userRoles = (from e in ebatch
                                 join s in support
                                 on e.t.Nik equals s.Nik
                                 orderby e.m.Roledescription, s.Username
                                 select new
                                 {
                                     id = e.t.RecordId,
                                     roleId = e.m.Roleid,
                                     roleName = e.m.Roledescription,
                                     nik = e.t.Nik,
                                     username = s.Username,
                                     description = e.t.Description,
                                 }).ToList();

                return userRoles;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<object> GetUserRoleByNikAsync(string nik)
        {
            try
            {
                var ebatch = (from t in _approvalContext.EbatchUserroleidTs
                              join m in _approvalContext.EbatchRoleidMs
                              on t.RoleidFk equals m.Roleid
                              select new
                              {
                                  t,
                                  m
                              }).ToList();

                var support = _supportContext.MUserAllApps.ToList();

                var userRoles = (from e in ebatch
                                 join s in support
                                 on e.t.Nik equals s.Nik
                                 where e.t.Nik == nik
                                 orderby e.m.Roledescription, s.Username
                                 select new
                                 {
                                     id = e.t.RecordId,
                                     roleId = e.m.Roleid,
                                     roleName = e.m.Roledescription,
                                     nik = e.t.Nik,
                                     username = s.Username,
                                     description = e.t.Description,
                                 }).ToList();

                return userRoles;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
