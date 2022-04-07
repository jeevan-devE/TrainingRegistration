using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingRegistration.Configuration;
using TrainingRegistration.EntityFrameworkCore;
using TrainingRegistration.Migrator.DependencyInjection;

namespace TrainingRegistration.Migrator
{
    [DependsOn(typeof(TrainingRegistrationEntityFrameworkModule))]
    public class TrainingRegistrationMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TrainingRegistrationMigratorModule(TrainingRegistrationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(TrainingRegistrationMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TrainingRegistrationConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainingRegistrationMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
