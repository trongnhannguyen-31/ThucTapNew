﻿using AutoMapper;
using Falcon.Web.Core.Auth;
using Phoenix.Server.Data.Entity;
using Phoenix.Shared.Common;
using Phoenix.Shared.Customer;
using Phoenix.Shared.Order;
using Phoenix.Shared.OrderDetail;
using Phoenix.Shared.Product;
using Phoenix.Shared.ProductSKU;
using Phoenix.Shared.ProductType;
using Phoenix.Shared.Rating;
using Phoenix.Shared.User;
using Phoenix.Shared.Vendor;
using Phoenix.Shared.Warehouse;
using Phoenix.Shared.WarehouseMenu;

namespace Phoenix.Server.Services.Infrastructure
{
    public class AutoMapperWebProfile : Profile
    {
        public AutoMapperWebProfile()
        {
            // CreateMap ProductType
            CreateMap<ProductType, ProductTypeDto>();

            // CreateMap Vendor
            CreateMap<Vendor, VendorDto>()
                .ForMember(d => d.Logo_Link, o => o.MapFrom(s => s.ImageRecord.FileName));


            // CreateMap Product
            CreateMap<Product, ProductDto>();

            // CreateMap ProductSKU
            CreateMap<ProductSKU, ProductSKUDto>()
                .ForMember(d => d.NameProduct, o => o.MapFrom(s => s.Product.Name));

            // CreateMap Warehouse
            CreateMap<Warehouse, WarehouseDto>()
                .ForMember(d => d.Product_Name, o => o.MapFrom(s => s.ProductSKU.Product.Name));

            // CreateMap Order
            CreateMap<Order, OrderDto>()
                .ForMember(d => d.Customer_Name, o => o.MapFrom(s => s.Customer.FullName));
            //.ForMember(d => d.Status_Name, o => o.MapFrom(s => s.Status == 1 ? "Chờ duyệt" : s.Status == 2 ? "Đã duyệt" : s.Status == 3 ? "Đã giao" : "Hủy"));


            // CreateMap OrderDetail
            CreateMap<OrderDetail, OrderDetailDto>();
                //.ForMember(d => d.Product_Name, o => o.MapFrom(s => s.Product.Name));


            // CreateMap Customer
            CreateMap<Customer, CustomerDto>();

            // CreateMap Rating
            CreateMap<Rating, RatingDto>()
                .ForMember(d => d.Customer_Name, o => o.MapFrom(s => s.Customer.FullName))
                .ForMember(d => d.Product_Name, o => o.MapFrom(s => s.Product.Name));

            // CreateMap User
            CreateMap<User, UserDto>();

            CreateMap<ProductTypeDto, DropdownDto>();
            
            CreateMap<VendorDto, DropdownDto>();

            CreateMap<ProductSKUDto, DropdownDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.NameProduct));

            CreateMap<ProductDto, DropdownDto>();

            CreateMap<WarehouseMenu, WarehouseMenuDto>();

            CreateMap<WarehouseMenuDto, DropdownDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.SKUId))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.ProductName));
        }
    }
}

