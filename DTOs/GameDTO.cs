namespace UniBet.DTOs
{
    public class GameDTOResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }

    public class GameDTORequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
    
}
