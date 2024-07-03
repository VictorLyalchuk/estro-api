namespace Core.DTOs.UserInfo
{
    public class UserBonusesDTO
    {
        public int Id { get; set; }
        public int? Name { get; set; }
        public DateTime OrderDate { get; set; }
        public string? BonusesOperation { get; set; }
        public string? BonusesDescription { get; set; }
        public decimal? BonusesAccrued { get; set; }
        public string? UserId { get; set; }
    }
}
