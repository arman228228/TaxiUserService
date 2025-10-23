using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DriverRepository : IDriverRepository
{
    private readonly AppDbContext _context;

    public DriverRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Driver> CreateAsync(Driver driver)
    {
        await _context.Drivers.AddAsync(driver);
        await _context.SaveChangesAsync();
        return driver;
    }
    
    public async Task<Driver?> GetByIdAsync(int id)
    {
        return await _context.Drivers.FirstOrDefaultAsync(d => d.Id == id);
    }
}