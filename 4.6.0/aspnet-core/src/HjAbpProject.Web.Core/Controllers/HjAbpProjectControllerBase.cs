using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HjAbpProject.Controllers
{
    public abstract class HjAbpProjectControllerBase: AbpController
    {
        protected HjAbpProjectControllerBase()
        {
            LocalizationSourceName = HjAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
