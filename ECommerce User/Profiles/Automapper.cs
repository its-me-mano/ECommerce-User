using AutoMapper;
using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using ECommerce_User.Models;
using System;

namespace ECommerce_User.Profiles
{
    public class Automapper : Profile
    {
        public Automapper() {

            // Address
            CreateMap<AddressCreatingDto,Address>().ForMember(
             dest => dest.Country,
             opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
             ).ReverseMap();
            CreateMap<AddressUpdatingDto,Address>().ForMember(
                dest => dest.Country,
                opt => opt.MapFrom(src => (Guid.Parse(src.Country)))
            ).ForMember(
                    dest => dest.Type,
                    opt => opt.MapFrom(src => (Guid.Parse(src.Type)))
           ).ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();


            //Asset
            CreateMap<Asset, AssetDtoCreating>().ReverseMap();
            CreateMap<Asset, AssetUpdateDto>().ReverseMap();
            CreateMap<AssetDto, Asset>().ReverseMap();


            //Email
            CreateMap<EmailCreatingDto, Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.type)))
            ).ReverseMap();
            CreateMap<EmailUpdatingDto, Email>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.type)))
            ).ReverseMap();
            CreateMap<EmailDto, Email>().ReverseMap();


            //Phone
            CreateMap<PhoneCreatingDto, Phone>().ForMember(
               dest => dest.TypeId,
               opt => opt.MapFrom(src => (Guid.Parse(src.type)))
           ).ReverseMap();

            CreateMap<PhoneUpdatingDto,Phone>().ForMember(
                dest => dest.TypeId,
                opt => opt.MapFrom(src => (Guid.Parse(src.type)))
            ).ReverseMap();
            CreateMap<PhoneDto,Phone>().ReverseMap();

            //Refset
            CreateMap<RefTermDto, RefTerm>().ReverseMap(); 
            CreateMap<MetaDataDto, RefSet>();

            //User
            CreateMap<UserCreatingDto, User>().ReverseMap();
            CreateMap<UserUpdatingDto, User>().ReverseMap();
            CreateMap<User,UserDto>();

            //Card
            CreateMap<CardCreatingDto, Card>().ReverseMap();
            CreateMap<CardUpdatingDto, Card>().ReverseMap();
            CreateMap<CardDto, Card>().ReverseMap();

            //UPI
            CreateMap<UPI, UpiDto>().ReverseMap();
            CreateMap<UPICreatingDto, UPI>().ReverseMap();
            CreateMap<UPIUpdatingDto, UPI>().ReverseMap();

        }
    }
}
