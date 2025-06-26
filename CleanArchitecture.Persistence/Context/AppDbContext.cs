using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context;
public sealed class AppDbContext : IdentityDbContext<User,IdentityRole,string>,IUnitOfWork
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    // Entitylere ait özelleştirme yapılabilen alan
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        modelBuilder.Ignore<IdentityUserLogin<string>>();
        modelBuilder.Ignore<IdentityUserRole<string>>();
        modelBuilder.Ignore<IdentityUserClaim<string>>();
        modelBuilder.Ignore<IdentityUserToken<string>>();
        modelBuilder.Ignore<IdentityRoleClaim<string>>();
        modelBuilder.Ignore<IdentityRole<string>>();
    }
        

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entities = ChangeTracker.Entries<Entity>();

        foreach (var entity in entities)
        {
            if(entity.State==EntityState.Added)
                entity.Property(p=>p.CreatedDate)
                    .CurrentValue=DateTime.Now;
            if (entity.State == EntityState.Modified)

                entity.Property(p => p.UpdateDate)
                    .CurrentValue = DateTime.Now;
        }
        return base.SaveChangesAsync(cancellationToken);
    }
   
}
