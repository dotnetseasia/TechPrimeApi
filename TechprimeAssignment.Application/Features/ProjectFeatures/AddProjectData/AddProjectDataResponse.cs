using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechprimeAssignment.Application.Features.ProjectFeatures.AddProjectData
{
    public class AddProjectDataResponse
    {
        public Guid id { get; set; }
        public string Projectname { get; set; }
        public string Reason { get; set; }
        public string Type { get; set; }
        public string Division { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Dept { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
    }
}
