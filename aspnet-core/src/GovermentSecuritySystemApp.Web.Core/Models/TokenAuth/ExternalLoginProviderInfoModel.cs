using Abp.AutoMapper;
using GovermentSecuritySystemApp.Authentication.External;

namespace GovermentSecuritySystemApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
