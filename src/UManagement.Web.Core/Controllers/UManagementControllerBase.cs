using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace UManagement.Controllers
{
    public abstract class UManagementControllerBase: AbpController
    {
        protected UManagementControllerBase()
        {
            LocalizationSourceName = UManagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
