﻿using Core.Entities.Category;

namespace Core.DTOs.Category
{
    public class MainCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
        public string URLCategoryName { get; set; } = string.Empty;
        public string URLSubCategoryName { get; set; } = string.Empty;
        public string URLName { get; set; } = string.Empty;
        public IEnumerable<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

    }
}
