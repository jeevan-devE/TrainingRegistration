using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TrainingRegistration.Authorization.Roles;
using TrainingRegistration.Authorization.Users;
using TrainingRegistration.MultiTenancy;

namespace TrainingRegistration.EntityFrameworkCore
{
    public class TrainingRegistrationDbContext : AbpZeroDbContext<Tenant, Role, User, TrainingRegistrationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TrainingRegistrationDbContext(DbContextOptions<TrainingRegistrationDbContext> options)
            : base(options)
        {
        }
    }
}
