using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechprimeAssignment.Domain.Entities;
using TruckLotParking.Application.Repositories;
using TruckLotParking.Domain.Entities;

namespace TechprimeAssignment.Application.Repositories
{
    public interface IProjects : IBaseRepository<TblProject>
    {
        Task<TblProject> GetprojectbyProjectname (string projectName);

    }
}
