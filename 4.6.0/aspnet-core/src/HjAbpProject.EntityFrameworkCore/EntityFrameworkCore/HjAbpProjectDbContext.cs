using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HjAbpProject.Authorization.Roles;
using HjAbpProject.Authorization.Users;
using HjAbpProject.MultiTenancy;
using HjAbpProject.Tasks;
using HjAbpProject.Peron;

namespace HjAbpProject.EntityFrameworkCore
{
    public class HjAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, HjAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HjAbpProjectDbContext(DbContextOptions<HjAbpProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
