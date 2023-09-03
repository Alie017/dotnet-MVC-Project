﻿using AlisverisProje.Areas.Identity.Data;
using AlisverisProje.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlisverisProje.Data;

public class AlisverisContext : IdentityDbContext<AlisverisProjeUser>
{
    public AlisverisContext(DbContextOptions<AlisverisContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<List> Lists { get; set; }




    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }




    public DbSet<AlisverisProje.Models.Detail> Detail { get; set; } = default!;
}
