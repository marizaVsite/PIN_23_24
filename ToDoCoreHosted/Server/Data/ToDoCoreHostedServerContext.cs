using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoCoreHosted.Shared;

namespace ToDoCoreHosted.Server.Data
{
    public class ToDoCoreHostedServerContext : DbContext
    {
        public ToDoCoreHostedServerContext (DbContextOptions<ToDoCoreHostedServerContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoCoreHosted.Shared.TodoItem> TodoItem { get; set; } = default!;
    }
}
