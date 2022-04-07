using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingRegistration.EntityFrameworkCore;
using TrainingRegistration.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TrainingRegistration.Web.Tests
{
    [DependsOn(
        typeof(TrainingRegistrationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TrainingRegistrationWebTestModule : AbpModule
    {
        public TrainingRegistrationWebTestModule(TrainingRegistrationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainingRegistrationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TrainingRegistrationWebMvcModule).Assembly);
        }
    }
}