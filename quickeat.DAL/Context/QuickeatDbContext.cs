using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using quickeat.Core.Models;
using quickeat.DAL.Repositories.Concrete;

namespace quickeat.DAL.Context;

public class QuickeatDbContext : IdentityDbContext<QuickeatUser>
{
    public QuickeatDbContext(DbContextOptions<QuickeatDbContext> options)
        : base(options) { }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<MenuCategory> MenuCategories { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PartnerApplication> PartnerApplications { get; set; }
    public DbSet<Blog> Blogs { get; set; }
}
