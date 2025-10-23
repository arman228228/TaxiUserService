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
}