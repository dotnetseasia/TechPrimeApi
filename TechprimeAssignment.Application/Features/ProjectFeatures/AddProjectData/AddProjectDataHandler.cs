using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechprimeAssignment.Application.Repositories;
using TechprimeAssignment.Domain.Entities;
using TruckLotParking.Application.Common.Exceptions;
using TruckLotParking.Application.Features.UserFeatures.CreateUser;
using TruckLotParking.Application.Repositories;
using TruckLotParking.Domain.Entities;

namespace TechprimeAssignment.Application.Features.ProjectFeatures.AddProjectData
{
    public sealed class AddProjectDataHandler:IRequestHandler<AddProjectDataRequest, AddProjectDataResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProjects _projectRepository;

        public AddProjectDataHandler(IProjects projectRepository, IUnitOfWork unitOfWork,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _projectRepository = projectRepository;
        }
        public async Task<AddProjectDataResponse> Handle(AddProjectDataRequest request, CancellationToken cancellationToken)
        {
            try
            {
                TblProject project = await _projectRepository.GetprojectbyProjectname(request.Projectname);

                if (project != null)
                {
                    var existingProject = _mapper.Map<AddProjectDataResponse>(project);
                    existingProject.Message = "Project already exists.";
                    return existingProject;
                }
                else
                {
                    var newProject = _mapper.Map<TblProject>(request);
                    _projectRepository.Create(newProject);
                    await _unitOfWork.Save(cancellationToken);
                    var createdProject = _mapper.Map<AddProjectDataResponse>(newProject);
                    createdProject.Message = "Project Added Successfully ";
                    return createdProject;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
    }
}
