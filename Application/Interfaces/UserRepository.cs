using Domain.Entities;

namespace Application.Interfaces;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
}