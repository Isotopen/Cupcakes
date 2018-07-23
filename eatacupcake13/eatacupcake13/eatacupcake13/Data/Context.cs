using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using eatacupcake13.Models;

namespace eatacupcake13
{
    public class Context : DbContext
    {

        public Context()
        {
            Database.SetInitializer<Context>(new DatabaseInitializer());
        }

        public DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so the table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}