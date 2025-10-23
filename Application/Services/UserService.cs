using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<int> CreateAsync(UserDto userDto)
    {
        var existByEmail = await _userRepository.GetByEmailAsync(userDto.Email);
        if (existByEmail != null) return 0;
        
        var user = _mapper.Map<User>(userDto);
        var created  = await _userRepository.CreateAsync(user);
        return created.Id;
    }
    
    public async Task<UserDto?> GetByIdAsync(int id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return null;
        return _mapper.Map<UserDto>(user);
    }
    
    public async Task<UserDto?> GetByEmailAsync(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        if (user == null) return null;
        return _mapper.Map<UserDto>(user);
    }
}