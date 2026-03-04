namespace UniBet.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime? RemovedAt { get; set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}
