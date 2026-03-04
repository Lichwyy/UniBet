namespace UniBet.Entities
{
    public class Deposit : BaseEntity
    {
        public float DepositAmount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string DepositType { get; set; }
        public DateTime Date { get; set; }
    }
}
