
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Services;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Persistence.Repositories;
using CleanArchitecture.Persistence.Services;
using CleanArchitecture.WebApi.Middleware;
using GenericRepository;

namespace CleanArchitecture.WebApi.Configurations;

public class PersistanceDIServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {

        services.AddTransient<ExceptionMiddleware>(); // Creates a new instance every time it's requested
        services.AddScoped<IUnitOfWork>(cfr => cfr.GetRequiredService<AppDbContext>());
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IMotorbikeRepository, MotorbikeRepository>();
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        services.AddScoped<IAuthService, AuthService>();     //IAuthService çağrılıdğında AuthService classını ver
        services.AddScoped<IMailService, MailService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IUserRoleService, UserRoleService>();
        services.AddScoped<IMotorbikeService, MotorbikeService>();

    }
}
