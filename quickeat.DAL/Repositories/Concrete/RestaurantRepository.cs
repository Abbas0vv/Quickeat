using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public Task CreateAsync(Restaurant restaurant)
    {
    }

    public Task DeleteAsync(int id)
    {
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
    }

    public Task UpdateAsync(Restaurant restaurant)
    {
    }
}
