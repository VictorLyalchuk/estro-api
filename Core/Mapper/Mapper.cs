﻿using Core.DTOs.UserInfo;
using Core.DTOs.Category;
using Core.DTOs.Image;
using Core.DTOs.Product;
using Core.DTOs.Storage;
using Core.DTOs.Store;
using Core.DTOs.User;
using Core.Entities.Category;
using Core.Entities.UserEntity;
using Core.Entities.UserInfo;
using Core.Entities.Product;
using Core.Entities.Store;
using Core.Entities.Address;
using Core.DTOs.Address;

namespace Core.Mapper
{
    public class Mapper : AutoMapper.Profile
    {
        public Mapper()
        {
            CreateMap<UserLoginDTO, User>();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<UserEditDTO, User>().ReverseMap();
            CreateMap<UserRegistrationDTO, User>().ReverseMap();


            CreateMap<MainCategoryDTO, MainCategory>().ReverseMap();
            CreateMap<SubCategoryDTO, SubCategory>().ReverseMap();
            CreateMap<CategoryDTO, CategoryEntity>().ReverseMap();
            CreateMap<CategoryDTO, CategoryEntity>()
                .ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => new SubCategory { Id = src.MainCategoryId.GetValueOrDefault() }));
            
            CreateMap<ProductDTO, ProductEntity>().ReverseMap();
            CreateMap<CreateProductDTO, ProductEntity>();
            CreateMap<EditProductDTO, ProductEntity>();
            CreateMap<ProductEntity, ProductDTO>()
                        .ForMember(dto => dto.ImagesPath, opt => opt.MapFrom(o => o.Images.Select(a => a.ImagePath)))
                        .ForMember(dest => dest.URLCategoryName, opt => opt.MapFrom(src => src.Category.URLName))
                        .ForMember(dest => dest.URLSubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.URLName))
                        .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.Name))
                        .ForMember(dest => dest.URLMainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.URLName))
                        .ForMember(dest => dest.MainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name));
            
            CreateMap<StorageDTO, StorageEntity>().ReverseMap();

            CreateMap<CreateStoreDTO, StoreEntity>();
            CreateMap<EditStoreDTO, StoreEntity>();
            CreateMap<StoreDTO, StoreEntity>();
            CreateMap<StoreEntity, StoreDTO>()
                        .ForMember(dto => dto.City, opt => opt.MapFrom(o => o.City.CityName));

            CreateMap<CountryEntity, CountryDTO>().ReverseMap();
            CreateMap<CityEntity, CityDTO>()
                        .ForMember(dto => dto.CountryName, opt => opt.MapFrom(o => o.Country.CountryName));

            CreateMap<ImageDTO, ImageEntity>().ReverseMap();
            CreateMap<ImageForHomeDTO, ImageForHome>();

            CreateMap<AddressDTO, AddressEntity>();
            CreateMap<InfoDTO, Info>()
                    .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options))
                    .ReverseMap();
            CreateMap<OptionsDTO, Options>()
                    .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                    .ReverseMap();

            CreateMap<UserFavoriteProduct, UserFavoriteProductDTO>()
                     .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Product.Price))
                     .ForMember(dest => dest.ProductImage, opt => opt.MapFrom(src => src.Product.Images.OrderBy(img => img.Id).FirstOrDefault().ImagePath))
                     .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                     .ForMember(dest => dest.Storages, opt => opt.MapFrom(src => src.Product.Storages));

            CreateMap<UserFavoriteProductDTO, UserFavoriteProduct>();
            CreateMap<UserBonuses, UserBonusesDTO>();

            CreateMap<OrderDTO, Order>().ReverseMap();
            CreateMap<OrderItemsDTO, OrderItems>();
            CreateMap<OrderItems, OrderItemsDTO>();

            CreateMap<BagDTO, Bag>().ReverseMap();
            CreateMap<BagUserDTO, Bag>().ReverseMap();
            CreateMap<BagItemsDTO, BagItems>();
            CreateMap<BagItems, BagItemsDTO>()
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
                        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
                        .ForMember(dest => dest.Article, opt => opt.MapFrom(src => src.Product.Article))
                        .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Product.Images.OrderBy(img => img.Id).FirstOrDefault().ImagePath));
        }
    }
}
