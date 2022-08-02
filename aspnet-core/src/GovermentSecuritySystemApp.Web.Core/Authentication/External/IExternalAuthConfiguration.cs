using System.Collections.Generic;

namespace GovermentSecuritySystemApp.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
