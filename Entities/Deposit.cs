namespace UniBet.Entities
{
    public class Deposit : BaseEntity
    {
        public float DepositAmount { get; set; }
        public int UserId { get; set; }
        public string DepositType { get; set; }
        public DateTime Date { get; set; }
    }
}
