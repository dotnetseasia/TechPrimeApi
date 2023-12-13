using AutoMapper;
using TruckLotParking.Domain.Entities;

namespace TruckLotParking.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}