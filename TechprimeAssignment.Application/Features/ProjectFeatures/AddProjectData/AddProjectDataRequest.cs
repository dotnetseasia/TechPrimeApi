using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechprimeAssignment.Application.Features.ProjectFeatures.AddProjectData
{

    public sealed record AddProjectDataRequest(string Projectname,string Reason,
     string Type,
     string Division,
     string Category,
     string Priority,
     string Dept,
     string Status,
     string Location,
     DateTime Startdate,
     DateTime Enddate) : IRequest<AddProjectDataResponse>;

}
