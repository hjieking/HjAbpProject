using System.Threading.Tasks;
using HjAbpProject.Configuration.Dto;

namespace HjAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
