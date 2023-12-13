using TruckLotParking.Domain.Common;

namespace TruckLotParking.Domain.Entities;

public sealed class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
}