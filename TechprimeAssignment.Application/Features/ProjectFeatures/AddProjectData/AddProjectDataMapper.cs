using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechprimeAssignment.Domain.Entities;
using TruckLotParking.Application.Features.UserFeatures.CreateUser;
using TruckLotParking.Domain.Entities;

namespace TechprimeAssignment.Application.Features.ProjectFeatures.AddProjectData
{
    public sealed class AddProjectDataMapper : Profile
    {
        public AddProjectDataMapper()
        {
            CreateMap<AddProjectDataRequest, TblProject>();
            CreateMap<TblProject, AddProjectDataResponse>();
        }
    }
}
