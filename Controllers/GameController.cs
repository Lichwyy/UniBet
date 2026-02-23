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
        
        [HttpGet("{id}")]
        public IActionResult GetGameData(int id)
        {
            try
            {
                GameDTOResponse gameReponse = _service.GetGameData(id);
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
        [HttpPost]
        public IActionResult CreateGame([FromBody] GameDTORequest game)
        {
            try
            {
                _service.CreateGame(game);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGame(int id, [FromBody] GameDTORequest game)
        {
            try
            {
                GameDTOResponse gameReponse = _service.UpdateGame(id, game);
                return Ok(gameReponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        {
            try
            {
                _service.DeleteGame(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
