using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using UManagement.Authorization.Roles;
using UManagement.Authorization.Users;
using UManagement.MultiTenancy;

namespace UManagement.EntityFrameworkCore
{
    public class UManagementDbContext : AbpZeroDbContext<Tenant, Role, User, UManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UManagementDbContext(DbContextOptions<UManagementDbContext> options)
            : base(options)
        {
        }
    }
}
