using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreApp.API.Data.Entities;

namespace StoreApp.API.Data.Configurations
{
    /*public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "Yoni",
                    Email = "yoni@email.com",
                    Password = "1234",
                    AuthLevel = AuthLevels.User
                },
                new User
                {
                    Id = 2,
                    UserName = "Admin",
                    Email = "admin@email.com",
                    Password = "1234",
                    AuthLevel = AuthLevels.Admin

                }
            );
        }
    }*/
}
