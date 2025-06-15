using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using quickeat.Core.Models;
using quickeat.DAL.Context;
using quickeat.DAL.Repositories.Abstract;

namespace quickeat.DAL.Repositories.Concrete;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly QuickeatDbContext _context;

    public RestaurantRepository(QuickeatDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Restaurant restaurant)
    {
        await _context.Restaurants.AddAsync(restaurant);
    }

    public async Task DeleteAsync(int id)
    {
        var restaurant = await GetByIdAsync(id);
        _context.Restaurants.Remove(restaurant);
    }

    public async Task<List<Restaurant>> GetAllAsync()
    {
        return await _context.Restaurants.ToListAsync();
    }

    public async Task<Restaurant?> GetByIdAsync(int id)
    {
        return await _context.Restaurants.FindAsync(id);
    }

    public Task<List<Restaurant>> GetByOwnerAsync(string ownerId)
    {
        return _context.Restaurants
            .Where(r => r.OwnerId == ownerId)
            .OrderBy(r => r.Name)
            .ToListAsync();
    }

    public async Task UpdateAsync(Restaurant restaurant)
    {
        _context.Restaurants.Update(restaurant);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}
