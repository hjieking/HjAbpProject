using System.Threading.Tasks;
using Abp.Application.Services;
using HjAbpProject.Sessions.Dto;

namespace HjAbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
