using Domain.Entities;

namespace Application.Interfaces;

public interface IDriverRepository
{
    Task<Driver> CreateAsync(Driver user);
    Task<Driver?> GetByIdAsync(int id);
}