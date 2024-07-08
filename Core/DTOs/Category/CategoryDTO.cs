﻿using Core.Entities.Category;
using Core.Entities.Product;

namespace Core.DTOs.Category
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string? Name_en { get; set; }
        public string? Name_es { get; set; }
        public string? Name_uk { get; set; }
        public string? Name_fr { get; set; }
        public string? URLName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; } = new List<ProductEntity>();
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public int? MainCategoryId { get; set; }
        public MainCategory? MainCategory { get; set; }
    }
}
