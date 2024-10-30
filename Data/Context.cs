using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ticket_System.Data
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
