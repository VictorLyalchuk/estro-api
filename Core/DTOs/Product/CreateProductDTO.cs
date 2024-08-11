﻿using Core.Entities.Product;

namespace Core.DTOs.Product
{
    public class CreateProductDTO
    {
        public string Name_en { get; set; } = string.Empty;
        public string Name_uk { get; set; } = string.Empty;
        public string Name_es { get; set; } = string.Empty;
        public string Name_fr { get; set; } = string.Empty;
        public string Description_en { get; set; } = string.Empty;
        public string Description_uk { get; set; } = string.Empty;
        public string Description_es { get; set; } = string.Empty;
        public string Description_fr { get; set; } = string.Empty;
        public List<string>? Highlights_en { get; set; }
        public List<string>? Highlights_uk { get; set; }
        public List<string>? Highlights_es { get; set; }
        public List<string>? Highlights_fr { get; set; }
        public decimal Price { get; set; }
        public int SeasonId { get; set; }
        public int ColorId { get; set; }
        public int MaterialId { get; set; }
        public string Article { get; set; } = string.Empty;
        public List<ImageEntity>? ImagesFile { get; set; }
        public int CategoryId { get; set; }
        public List<int>? Sizes { get; set; }



        //public string CategoryName { get; set; } = string.Empty;
        //public int? StorageId { get; set; }
        //public int StorageQuantity { get; set; }
    }
}