namespace UniBet.Entities
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime? RemovedAt { get; set; }

        public BaseEntity()
        {
            this.id = Guid.NewGuid();
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}
