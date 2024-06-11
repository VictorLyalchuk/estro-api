using Core.DTOs.Bag_and_Order;
using Core.DTOs.Category;
using Core.DTOs.Image;
using Core.DTOs.Information;
using Core.DTOs.Product;
using Core.DTOs.Storage;
using Core.DTOs.Store;
using Core.DTOs.User;
using Core.Entities.Category;
using Core.Entities.UserEntity;
using Core.Entities.Information;
using Core.Entities.Product;
using Core.Entities.Store;
using Core.Entities.Bag_and_Order;

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
            
            CreateMap<ProductDTO, ProductEntity>();
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
            CreateMap<StoreDTO, StoreEntity>().ReverseMap();
            CreateMap<CreateStoreDTO, StoreEntity>();
            CreateMap<EditStoreDTO, StoreEntity>();
            
            CreateMap<ImageDTO, ImageEntity>().ReverseMap();
            CreateMap<ImageForHomeDTO, ImageForHome>();

            CreateMap<AddressDTO, Address>();
            CreateMap<InfoDTO, Info>()
                    .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options))
                    .ReverseMap();
            CreateMap<OptionsDTO, Options>()
                    .ForMember(dest => dest.InfoId, opt => opt.MapFrom(src => src.Info))
                    .ReverseMap();


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
