using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechprimeAssignment.Application.Repositories;
using TechprimeAssignment.Domain.Entities;
using TruckLotParking.Domain.Entities;
using TruckLotParking.Persistence.Context;
using TruckLotParking.Persistence.Repositories;

namespace TechprimeAssignment.Persistence.Repositories
{
    public class Project : BaseRepository<TblProject>, IProjects
    {
        public Project(DataContext context) : base(context)
        {
        }

        public async Task<TblProject> GetprojectbyProjectname(string projectName)    {
            var project = await Context.tblProjects.FirstOrDefaultAsync(a => a.Projectname == projectName);
            return project;
        }
    }
}
