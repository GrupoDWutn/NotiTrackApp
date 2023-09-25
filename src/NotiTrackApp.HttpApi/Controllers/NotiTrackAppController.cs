using NotiTrackApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NotiTrackApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NotiTrackAppController : AbpControllerBase
{
    protected NotiTrackAppController()
    {
        LocalizationResource = typeof(NotiTrackAppResource);
    }
}
