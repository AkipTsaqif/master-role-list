using MasterRoleList.Interfaces;
using MasterRoleList.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterRoleList.Repositories
{
    public class DeleteUserRoleRepo : IDeleteUserRoleRepo
    {
        private readonly Master_ApprovalContext _context;

        public DeleteUserRoleRepo(Master_ApprovalContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteUserRole(EbatchUserroleidT userRole)
        {
            try
            {
                EbatchApprvldetailT apprvlDetail = await _context.EbatchApprvldetailTs.FirstOrDefaultAsync(ur => ur.Apprvlroleid == userRole.RoleidFk && ur.Nik == userRole.Nik);

                if (apprvlDetail == null)
                {
                    EbatchUserroleidT currUserRole = await _context.EbatchUserroleidTs.FirstOrDefaultAsync(ur => ur.RoleidFk == userRole.RoleidFk && ur.Nik == userRole.Nik);

                    if (currUserRole != null) {
                        _context.EbatchUserroleidTs.Remove(currUserRole);
                        await _context.SaveChangesAsync();

                        return true;
                    }

                    throw new Exception("User role tidak ditemukan!");
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
