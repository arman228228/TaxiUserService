using Application.DTOs;

namespace Application.Interfaces;

public interface IUserService
{
    Task<int> CreateAsync(UserDto user);
    Task<UserDto?> GetByEmailAsync(string email);
    Task<UserDto?> GetByIdAsync(int id);
}