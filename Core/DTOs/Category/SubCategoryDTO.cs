﻿using Core.Entities.Category;

namespace Core.DTOs.Category
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name_en { get; set; } = string.Empty;
        public string Name_es { get; set; } = string.Empty;
        public string Name_uk { get; set; } = string.Empty;
        public string Name_fr { get; set; } = string.Empty;
        public string? Description_en { get; set; }
        public string? Description_uk { get; set; }
        public string? Description_es { get; set; }
        public string? Description_fr { get; set; }
        public string URLName { get; set; }
        public string? ImagePath { get; set; }
        public IEnumerable<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
};

