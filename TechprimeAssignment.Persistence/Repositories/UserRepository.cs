using TruckLotParking.Application.Repositories;
using TruckLotParking.Domain.Entities;
using TruckLotParking.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using TechprimeAssignment.Domain.Entities;

namespace TruckLotParking.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }
    
    public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
    //public Task<TblProject> SaveDetails(string Name, CancellationToken cancellationToken)
    //{
    //    return Context.tblProjects.FirstOrDefaultAsync(x => x.id == Name, cancellationToken);
    //}
}