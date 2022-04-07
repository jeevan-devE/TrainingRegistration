using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingRegistration.Configuration;

namespace TrainingRegistration.Web.Host.Startup
{
    [DependsOn(
       typeof(TrainingRegistrationWebCoreModule))]
    public class TrainingRegistrationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TrainingRegistrationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainingRegistrationWebHostModule).GetAssembly());
        }
    }
}
