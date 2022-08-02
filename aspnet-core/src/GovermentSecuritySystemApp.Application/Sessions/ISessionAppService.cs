using System.Threading.Tasks;
using Abp.Application.Services;
using GovermentSecuritySystemApp.Sessions.Dto;

namespace GovermentSecuritySystemApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
