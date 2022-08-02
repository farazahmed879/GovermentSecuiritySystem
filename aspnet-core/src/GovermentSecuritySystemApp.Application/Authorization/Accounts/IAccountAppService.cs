using System.Threading.Tasks;
using Abp.Application.Services;
using GovermentSecuritySystemApp.Authorization.Accounts.Dto;

namespace GovermentSecuritySystemApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
