using TruckLotParking.Domain.Entities;

namespace TruckLotParking.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
   // Task<User> SaveProject(string email, CancellationToken cancellationToken);
}