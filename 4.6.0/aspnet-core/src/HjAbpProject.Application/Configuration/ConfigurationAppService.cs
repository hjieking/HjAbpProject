using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HjAbpProject.Configuration.Dto;

namespace HjAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HjAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
