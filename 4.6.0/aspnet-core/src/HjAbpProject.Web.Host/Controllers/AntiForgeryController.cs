using Microsoft.AspNetCore.Antiforgery;
using HjAbpProject.Controllers;

namespace HjAbpProject.Web.Host.Controllers
{
    public class AntiForgeryController : HjAbpProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
