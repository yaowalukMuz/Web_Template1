using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web_Template1.Models
{
    public class ConnectionDb :DbContext
    {
        // constanct method 

        public ConnectionDb(DbContextOptions<ConnectionDb> options)
            : base(options)
        { 
        }

        public DbSet<Account> Accounts { get; set; }


    }
}
