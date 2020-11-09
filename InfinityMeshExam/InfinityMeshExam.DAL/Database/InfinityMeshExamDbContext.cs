using InfinityMeshExam.DAL.Configuration;
using InfinityMeshExam.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Database
{
    public class InfinityMeshExamDbContext:DbContext
    {

        public InfinityMeshExamDbContext(DbContextOptions<InfinityMeshExamDbContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Blog> blogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);

        }

    }
}
