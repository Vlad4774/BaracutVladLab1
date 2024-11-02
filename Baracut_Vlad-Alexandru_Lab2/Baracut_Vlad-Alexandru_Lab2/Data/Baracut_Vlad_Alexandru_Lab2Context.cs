using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baracut_Vlad_Alexandru_Lab2.Models;

namespace Baracut_Vlad_Alexandru_Lab2.Data
{
    public class Baracut_Vlad_Alexandru_Lab2Context : DbContext
    {
        public Baracut_Vlad_Alexandru_Lab2Context (DbContextOptions<Baracut_Vlad_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Baracut_Vlad_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Baracut_Vlad_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Baracut_Vlad_Alexandru_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
