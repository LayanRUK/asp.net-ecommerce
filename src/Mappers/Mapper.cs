using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_sharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Mappers
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserReadDto, User>();
            CreateMap<UserCreateDto, User>();
            CreateMap<User, UserCreateDto>();
            CreateMap<UserUpdateDto, User>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcProperty) => srcProperty != null));

            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductReadDto, Product>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductCreateDto>();




            CreateMap<OrderItem, OrderItemReadDto>();
            CreateMap<OrderItemReadDto, OrderItem>();
            CreateMap<OrderItemCreateDto, OrderItem>();
            CreateMap<OrderItem, OrderItemCreateDto>();


            CreateMap<Order, OrderReadDto>();
            CreateMap<OrderReadDto, Order>();
            CreateMap<OrderCreatDto, Order>();
            CreateMap<Order, OrderCreatDto>();

CreateMap<ProductUpdateDto, Product>()
             .ForAllMembers(opts => opts.Condition((src, dest, srcProperty) => srcProperty != null));
        }
    }
}