using MasterRoleList.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterRoleList.Controllers
{
    public class UserDetailsController : ControllerBase
    {
        public readonly IUserDetailsService _userDetailsService;

        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet]
        [Route("GetUserDetails")]
        public async Task<IActionResult> GetUserDetails()
        {
            try
            {
                return Ok(new { status = "Success", message = "Berhasil mengambil data", data = await _userDetailsService.GetUserDetails() });
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }

        [HttpGet]
        [Route("GetRoleDetails")]
        public async Task<IActionResult> GetRoleDetails()
        {
            try
            {
                return Ok(new { status = "Success", message = "Berhasil mengambil data", data = await _userDetailsService.GetRoleDetails() });
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { status = "Error", message = ex.Message });
            }
        }
    }
}
