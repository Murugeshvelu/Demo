using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Boiler.MultiTenancy.Dto;

namespace Boiler.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
