using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class PortfolioIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public PortfolioIdentityDbContext(DbContextOptions<PortfolioIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
