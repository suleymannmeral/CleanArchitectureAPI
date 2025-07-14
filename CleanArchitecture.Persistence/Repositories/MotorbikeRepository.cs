using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistence.Context;
using GenericRepository;


namespace CleanArchitecture.Persistence.Repositories;

public class MotorbikeRepository : Repository<Motorbike, AppDbContext>, IMotorbikeRepository
{
    public MotorbikeRepository(AppDbContext context) : base(context)
    {
    }
}
