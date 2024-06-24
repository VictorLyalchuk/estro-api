using Core.Entities.UserEntity;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.UserInfo
{
    public class UserBonuses
    {
        [Key]
        public int Id { get; set; }
        public int? Name { get; set; }
        public DateTime OrderDate { get; set; }
        public string? BonusesOperation { get; set; }
        public string? BonusesDescription { get; set; }
        public decimal? BonusesAccrued { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
