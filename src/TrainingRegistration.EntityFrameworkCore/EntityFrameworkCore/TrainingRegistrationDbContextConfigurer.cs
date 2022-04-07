using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TrainingRegistration.EntityFrameworkCore
{
    public static class TrainingRegistrationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TrainingRegistrationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TrainingRegistrationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
