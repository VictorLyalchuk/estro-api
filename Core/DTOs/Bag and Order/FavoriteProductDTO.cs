﻿using Core.DTOs.Storage;

namespace Core.DTOs.Bag_and_Order
{
    public class FavoriteProductDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string? ProductImage { get; set; }
        public List<StorageDTO>? Storages { get; set; }
    }
}
