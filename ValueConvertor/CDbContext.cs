using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ValueConvertor
{
    public class CDbContext : DbContext
    {
        public CDbContext(DbContextOptions<CDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new TitleConvertorConvertor();
            modelBuilder
            .Entity<TitleValue>()
            .Property(e => e.Title)
            .HasConversion(converter);
        }
        public DbSet<TitleValue> Courses { get; set; }


    }


}
