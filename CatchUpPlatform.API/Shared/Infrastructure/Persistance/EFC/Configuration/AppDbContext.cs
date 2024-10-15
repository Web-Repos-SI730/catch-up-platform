using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.API.News.Shared.Infrastructure.Persistance.EFC.Configuration;

public class AppDbContext(DbContextOptions options): DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<FavoriteSource>().ToTable("FavoriteSources");
        //No olvidar la arrow function
        builder.Entity<FavoriteSource>().HasKey(f=>f.Id);
        builder.Entity<FavoriteSource>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<FavoriteSource>().Property(f=> f.SourceId).IsRequired();
        builder.Entity<FavoriteSource>().Property(f=> f.NewsApiKey).IsRequired();
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        base.ConfigureConventions(builder);
    }
}