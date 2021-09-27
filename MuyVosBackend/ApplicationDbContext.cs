using Microsoft.EntityFrameworkCore;
using MuyVosBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuyVosBackend
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }
    }
}
