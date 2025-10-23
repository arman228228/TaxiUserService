using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class DriverService : IDriverService
{
    private readonly IDriverRepository _driverRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public DriverService(IDriverRepository driverRepository, IUserRepository userRepository, IMapper mapper)
    {
        _driverRepository = driverRepository;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<int> CreateAsync(DriverDto driverDto)
    {
        var driver = _mapper.Map<Driver>(driverDto);
        
        var user = await _userRepository.GetByIdAsync(driverDto.UserId);
        if (user == null) return 0;
        
        driver.User = user;
        var created = await _driverRepository.CreateAsync(driver);
        return created.Id;
    }

    public async Task<DriverDto?> GetByIdAsync(int id)
    {
        var driver = await _driverRepository.GetByIdAsync(id);
        if (driver == null) return null;
        return _mapper.Map<DriverDto>(driver);
    }
}