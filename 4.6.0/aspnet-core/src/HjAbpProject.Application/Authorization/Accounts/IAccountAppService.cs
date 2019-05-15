using System.Threading.Tasks;
using Abp.Application.Services;
using HjAbpProject.Authorization.Accounts.Dto;

namespace HjAbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
