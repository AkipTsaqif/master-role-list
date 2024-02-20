using MasterRoleList.Interfaces;
using MasterRoleList.Models;

namespace MasterRoleList.Repositories
{
    public class SaveUserRoleRepo : ISaveUserRoleRepo
    {
        private readonly Master_ApprovalContext _context;
        public SaveUserRoleRepo(Master_ApprovalContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveUserRole(EbatchUserroleidT userRole)
        {
            try
            {
                EbatchUserroleidT isExist = _context.EbatchUserroleidTs.Where(x => x.Nik == userRole.Nik && x.RoleidFk == userRole.RoleidFk).FirstOrDefault();

                EbatchUserroleidT newUserRole = new EbatchUserroleidT()
                {
                    Nik = userRole.Nik,
                    RoleidFk = userRole.RoleidFk,
                    Description = userRole.Description,
                    Createdby = userRole.Createdby,
                    Creationdate = DateTime.Now,
                    Updateby = userRole.Updateby,
                    Updatedate = DateTime.Now
                };

                if (isExist == null)
                {
                    _context.EbatchUserroleidTs.Add(newUserRole);
                    await _context.SaveChangesAsync();
                    return true;
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
