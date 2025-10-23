using Application.DTOs;

namespace Application.Interfaces;

public interface IDriverService
{
    Task<int> CreateAsync(DriverDto user);
    Task<DriverDto?> GetByIdAsync(int id);
}