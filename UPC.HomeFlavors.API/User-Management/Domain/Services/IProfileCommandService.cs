using UPC.HomeFlavors.API.Profiles.Domain.Model.Aggregates;
using UPC.HomeFlavors.API.Profiles.Domain.Model.Commands;

namespace UPC.HomeFlavors.API.Profiles.Domain.Services
{
    public interface IProfileCommandService
    {
        Task<Profile?> Handle(CreateProfileCommand command);
    }
}