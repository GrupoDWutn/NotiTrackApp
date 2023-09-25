using System;
using System.Collections.Generic;
using System.Text;
using NotiTrackApp.Localization;
using Volo.Abp.Application.Services;

namespace NotiTrackApp;

/* Inherit your application services from this class.
 */
public abstract class NotiTrackAppAppService : ApplicationService
{
    protected NotiTrackAppAppService()
    {
        LocalizationResource = typeof(NotiTrackAppResource);
    }
}
