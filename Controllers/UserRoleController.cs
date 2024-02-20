using MasterRoleList.Interfaces;
using MasterRoleList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterRoleList.Controllers
{
    public class UserRoleController : ControllerBase
    {
        public readonly IUserRoleService _userRoleService;
        public readonly ISaveUserRoleService _saveUserRoleService;
        public readonly IDeleteUserRoleService _deleteUserRoleService;

        public UserRoleController(IUserRoleService userRoleService, ISaveUserRoleService saveUserRoleService, IDeleteUserRoleService deleteUserRoleService)
        {
            _userRoleService = userRoleService;
            _saveUserRoleService = saveUserRoleService;
            _deleteUserRoleService = deleteUserRoleService;
        }

        [HttpGet]
        [Route("GetUserRoleList")]
        public async Task<IActionResult> GetUserRoleList()
        {
            try
            {
                var result = await _userRoleService.GetUserRolesAsync();
                return Ok(new { status = "Success", message = "Berhasil mengambil seluruh data role", data = result });
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetUserRoleByNik")]
        public async Task<IActionResult> GetUserRoleByNik(string nik)
        {
            try
            {
                var result = await _userRoleService.GetUserRoleByNikAsync(nik);
                return Ok(new { status = "Success", message = "Berhasil mengambil data role berdasarkan NIK", data = result });
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }

        [HttpPost]
        [Route("AddUserRole")]
        public async Task<IActionResult> AddUserRole([FromBody] EbatchUserroleidT userRole)
        {
            try
            {
                // cek data kosong
                if (string.IsNullOrEmpty(userRole.Nik) ||
                    string.IsNullOrEmpty(userRole.RoleidFk) ||
                    string.IsNullOrEmpty(userRole.Description) ||
                    string.IsNullOrEmpty(userRole.Createdby) ||
                    string.IsNullOrEmpty(userRole.Updateby))
                {
                    return BadRequest(new { status = "Error", message = "Data tidak lengkap" });
                }

                bool result = await _saveUserRoleService.SaveUserRole(userRole);

                if (result)
                {
                    return Ok(new { status = "Success", message = "User role berhasil tersimpan" });
                }
                else
                {
                    return Conflict(new { status = "Error", message = "User role sudah terdaftar!"});
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }

        [HttpDelete]
        [Route("DeleteUserRole")]
        public async Task<IActionResult> DeleteUserRole([FromBody] EbatchUserroleidT userRole)
        {
            try
            {
                if (string.IsNullOrEmpty(userRole.Nik) ||
                    string.IsNullOrEmpty(userRole.RoleidFk))
                {
                    return BadRequest(new { status = "Error", message = "Data tidak lengkap" });
                }

                bool isDeleted = await _deleteUserRoleService.DeleteUserRole(userRole);

                if (isDeleted)
                {
                    return Ok(new { status = "Success", message = "User role berhasil dihapus" });
                }

                return Conflict(new { status = "Error", message = "User role tidak dapat dihapus karena masih ada tanggungan approval!" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }
    }
}