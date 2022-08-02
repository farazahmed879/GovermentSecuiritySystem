using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GovermentSecuritySystemApp.Configuration.Dto;

namespace GovermentSecuritySystemApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GovermentSecuritySystemAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
