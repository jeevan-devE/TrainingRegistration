using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingRegistration.Authorization;

namespace TrainingRegistration
{
    [DependsOn(
        typeof(TrainingRegistrationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TrainingRegistrationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TrainingRegistrationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TrainingRegistrationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
