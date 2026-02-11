using Microsoft.AspNetCore.Mvc;
using UniBet.DTOs;
using UniBet.Entities;
using UniBet.Interfaces.IServices;
namespace UniBet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _service;
        public GameController(IGameService service) { 
            _service = service;
        }
        
        [HttpGet("{Id}")]
        public IActionResult GetGameData([FromQuery] int Id)
        {
            try
            {
                GameDTOResponse gameReponse = _service.GetGameData(Id);
                return Ok(gameReponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetAllGameData()
        {
            try
            {
                List<Game> gamesResponse = _service.GetAllGameData();
                return Ok(gamesResponse);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Game")]
        public IActionResult CreateGame([FromBody] GameDTORequest Game)
        {
            try
            {
                _service.CreateGame(Game);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("game/{Id}")]
        public IActionResult UpdateGame([FromQuery] int Id, [FromBody] GameDTORequest Game)
        {
            try
            {
                GameDTOResponse gameReponse = _service.UpdateGame(Id, Game);
                return Ok(gameReponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("")]
        public IActionResult DeleteGame(int Id)
        {
            try
            {
                _service.DeleteGame(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
