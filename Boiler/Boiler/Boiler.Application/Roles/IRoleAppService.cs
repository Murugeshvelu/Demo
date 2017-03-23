using System.Threading.Tasks;
using Abp.Application.Services;
using Boiler.Roles.Dto;

namespace Boiler.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
