using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping;

public class DriverProfile : Profile
{
    public DriverProfile()
    {
        CreateMap<DriverDto, Driver>();
        CreateMap<Driver, DriverDto>();
    }
}