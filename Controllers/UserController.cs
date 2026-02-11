using Microsoft.AspNetCore.Mvc;
using UniBet.Entities;
using UniBet.DTOs;
using UniBet.Interfaces.IServices;


namespace UniBet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service) {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetUserData(int id)
        {
            User UserResponse = _service.GetUserData(id);
            
            return Ok(UserResponse);
        }
        [HttpPost]
        public IActionResult Deposit(DepositDTO amount)
        {
            try
            {
                _service.Deposit(amount);
                return Created();

            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
    }
}
