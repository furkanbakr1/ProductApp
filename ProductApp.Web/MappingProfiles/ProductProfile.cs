using AutoMapper;
using ProductApp.Entities;
using ProductApp.Web.Models;

namespace ProductApp.Web.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
