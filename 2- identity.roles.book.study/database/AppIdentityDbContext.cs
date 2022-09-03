using _2__identity.roles.book.study.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2__identity.roles.book.study.database
{
    public class AppIdentityDbContext:IdentityDbContext<AppUser> { 
    

    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {

        }
    }
}
