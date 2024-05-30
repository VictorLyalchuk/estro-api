using Core.DTOs.Category;
using Core.DTOs.GoogleUser;
using Core.DTOs.Image;
using Core.DTOs.Information;
using Core.DTOs.Product;
using Core.DTOs.Storage;
using Core.DTOs.Store;
using Core.DTOs.User;
using Core.Entities.Category;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Product;
using Core.Entities.Store;

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

            CreateMap<GoogleUserRegistrationDTO, User>().ReverseMap();
            CreateMap<GoogleUserDTO, User>().ReverseMap();


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

            CreateMap<OptionsDTO, Options>();
            CreateMap<InfoDTO, Info>();
            CreateMap<OrderDTO, Order>().ReverseMap();

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
