﻿namespace Core.DTOs.UserInfo
{
    public class UserBonusesDTO
    {
        public int Id { get; set; }
        public int? Name { get; set; }
        public DateTime OrderDate { get; set; }
        public string? BonusesOperation_en { get; set; }
        public string? BonusesOperation_uk { get; set; }
        public string? BonusesOperation_es { get; set; }
        public string? BonusesOperation_fr { get; set; }
        public string? BonusesDescription_en { get; set; }
        public string? BonusesDescription_uk { get; set; }
        public string? BonusesDescription_es { get; set; }
        public string? BonusesDescription_fr { get; set; }
        public decimal? BonusesAccrued { get; set; }
        public string? UserId { get; set; }
    }
}
