using Microsoft.EntityFrameworkCore;
using Parcial1_Apd2_20180240.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Apd2_20180240.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source =Data\BaseDeDatos.db");
        }
    }
}
