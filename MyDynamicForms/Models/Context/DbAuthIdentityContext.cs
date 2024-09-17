using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class DbAuthIdentityContext : IdentityDbContext<IdentityUser>
{
    public DbAuthIdentityContext(DbContextOptions<DbAuthIdentityContext> options)
        : base(options)
    {
    }
}
