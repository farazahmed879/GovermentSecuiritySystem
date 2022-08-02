using System.Threading.Tasks;
using GovermentSecuritySystemApp.Configuration.Dto;

namespace GovermentSecuritySystemApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
