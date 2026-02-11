using UniBet.Entities;
using UniBet.DTOs;

namespace UniBet.Interfaces.IServices
{
    public interface IGameService
    {
        public GameDTOResponse GetGameData(int Id);
        public List<Game> GetAllGameData();
        public void CreateGame(GameDTORequest Game);
        public GameDTOResponse UpdateGame(int Id, GameDTORequest Game);
        public void DeleteGame(int Id);


    }
}
