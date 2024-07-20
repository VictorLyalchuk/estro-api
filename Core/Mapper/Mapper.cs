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

            CreateMap<ProductColorsDTO, ProductColors>()
                .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();

            CreateMap<ProductSeasonDTO, ProductSeason>()
                .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                 .ReverseMap();

            CreateMap<ProductMaterialDTO, ProductMaterial>()
                .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();

            CreateMap<ProductSizeDTO, ProductSize>()
                .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                .ReverseMap();

            CreateMap<ProductDTO, ProductEntity>().ReverseMap();
            CreateMap<CreateProductDTO, ProductEntity>();
            CreateMap<EditProductDTO, ProductEntity>();
            CreateMap<ProductEntity, ProductDTO>()
                        .ForMember(dto => dto.ImagesPath, opt => opt.MapFrom(o => o.Images.Select(a => a.ImagePath)))
                        .ForMember(dest => dest.URLCategoryName, opt => opt.MapFrom(src => src.Category.URLName))
                        .ForMember(dest => dest.CategoryName_en, opt => opt.MapFrom(src => src.Category.Name_en))
                        .ForMember(dest => dest.CategoryName_uk, opt => opt.MapFrom(src => src.Category.Name_uk))
                        .ForMember(dest => dest.CategoryName_es, opt => opt.MapFrom(src => src.Category.Name_es))
                        .ForMember(dest => dest.CategoryName_fr, opt => opt.MapFrom(src => src.Category.Name_fr))
                        .ForMember(dest => dest.URLSubCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.URLName))
                        .ForMember(dest => dest.SubCategoryName_en, opt => opt.MapFrom(src => src.Category.SubCategory.Name_en))
                        .ForMember(dest => dest.SubCategoryName_uk, opt => opt.MapFrom(src => src.Category.SubCategory.Name_uk))
                        .ForMember(dest => dest.SubCategoryName_es, opt => opt.MapFrom(src => src.Category.SubCategory.Name_es))
                        .ForMember(dest => dest.SubCategoryName_fr, opt => opt.MapFrom(src => src.Category.SubCategory.Name_fr))
                        .ForMember(dest => dest.URLMainCategoryName, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.URLName))
                        .ForMember(dest => dest.MainCategoryName_en, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name_en))
                        .ForMember(dest => dest.MainCategoryName_uk, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name_uk))
                        .ForMember(dest => dest.MainCategoryName_es, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name_es))
                        .ForMember(dest => dest.MainCategoryName_fr, opt => opt.MapFrom(src => src.Category.SubCategory.MainCategory.Name_fr))
                        .ForMember(dest => dest.Color_en, opt => opt.MapFrom(src => src.Color.Name_en))
                        .ForMember(dest => dest.Season_en, opt => opt.MapFrom(src => src.Season.Name_en))
                        .ForMember(dest => dest.Material_en, opt => opt.MapFrom(src => src.Material.Name_en))
                        .ForMember(dest => dest.Color_uk, opt => opt.MapFrom(src => src.Color.Name_uk))
                        .ForMember(dest => dest.Season_uk, opt => opt.MapFrom(src => src.Season.Name_uk))
                        .ForMember(dest => dest.Material_uk, opt => opt.MapFrom(src => src.Material.Name_uk))
                        .ForMember(dest => dest.Color_es, opt => opt.MapFrom(src => src.Color.Name_es))
                        .ForMember(dest => dest.Season_es, opt => opt.MapFrom(src => src.Season.Name_es))
                        .ForMember(dest => dest.Material_es, opt => opt.MapFrom(src => src.Material.Name_es))
                        .ForMember(dest => dest.Color_fr, opt => opt.MapFrom(src => src.Color.Name_fr))
                        .ForMember(dest => dest.Season_fr, opt => opt.MapFrom(src => src.Season.Name_fr))
                        .ForMember(dest => dest.Material_fr, opt => opt.MapFrom(src => src.Material.Name_fr));
            CreateMap<StorageDTO, StorageEntity>().ReverseMap();

            CreateMap<CreateStoreDTO, StoreEntity>();
            CreateMap<EditStoreDTO, StoreEntity>();
            CreateMap<StoreDTO, StoreEntity>();
            CreateMap<StoreEntity, StoreDTO>()
                        .ForMember(dto => dto.City, opt => opt.MapFrom(o => o.City.CityName_en));

            CreateMap<CountryEntity, CountryDTO>().ReverseMap();
            CreateMap<CityEntity, CityDTO>()
                        .ForMember(dto => dto.CountryName_en, opt => opt.MapFrom(o => o.Country.CountryName_en))
                        .ForMember(dto => dto.CountryName_es, opt => opt.MapFrom(o => o.Country.CountryName_es))
                        .ForMember(dto => dto.CountryName_fr, opt => opt.MapFrom(o => o.Country.CountryName_fr))
                        .ForMember(dto => dto.CountryName_uk, opt => opt.MapFrom(o => o.Country.CountryName_uk));

            CreateMap<ImageDTO, ImageEntity>().ReverseMap();
            CreateMap<ImageForHomeDTO, ImageForHome>();

            CreateMap<AddressDTO, AddressEntity>();
            CreateMap<InfoDTO, Info>()
                    .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                    .ForMember(dest => dest.Season, opt => opt.MapFrom(src => src.Season))
                    .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Materials))
                    .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Sizes))
                    .ReverseMap();

            CreateMap<UserFavoriteProduct, UserFavoriteProductDTO>()
                     .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Product.Price))
                     .ForMember(dest => dest.ProductImage, opt => opt.MapFrom(src => src.Product.Images.OrderBy(img => img.Id).FirstOrDefault().ImagePath))
                     .ForMember(dest => dest.ProductName_en, opt => opt.MapFrom(src => src.Product.Name_en))
                     .ForMember(dest => dest.ProductName_uk, opt => opt.MapFrom(src => src.Product.Name_uk))
                     .ForMember(dest => dest.ProductName_es, opt => opt.MapFrom(src => src.Product.Name_es))
                     .ForMember(dest => dest.ProductName_fr, opt => opt.MapFrom(src => src.Product.Name_fr))
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
                        .ForMember(dest => dest.Name_en, opt => opt.MapFrom(src => src.Product.Name_en))
                        .ForMember(dest => dest.Name_uk, opt => opt.MapFrom(src => src.Product.Name_uk))
                        .ForMember(dest => dest.Name_es, opt => opt.MapFrom(src => src.Product.Name_es))
                        .ForMember(dest => dest.Name_fr, opt => opt.MapFrom(src => src.Product.Name_fr))
                        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
                        .ForMember(dest => dest.Article, opt => opt.MapFrom(src => src.Product.Article))
                        .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Product.Images.OrderBy(img => img.Id).FirstOrDefault().ImagePath));
        }
    }
}
