using Microsoft.AspNetCore.Antiforgery;
using UManagement.Controllers;

namespace UManagement.Web.Host.Controllers
{
    public class AntiForgeryController : UManagementControllerBase
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
