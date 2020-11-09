using InfinityMeshExam.DAL.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Configuration
{
    public class BlogConfiguration:BaseEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(64);
            builder.Property(b => b.Summary).IsRequired().HasMaxLength(350);
            builder.Property(b => b.Content).IsRequired().HasMaxLength(3500);
            builder.Property(b => b.Published).IsRequired();

            builder.HasOne(b => b.User).WithMany(b => b.Blogs).HasForeignKey(b => b.UserId);


            builder.HasData(new List<Blog>
            {
                new Blog
                {
                    Id=1,
                    Title="Univerzalni tekst kojeg svi programeri koriste",
                    Summary="Lorem ipsum dolor sit amet",
                    Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                    "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",
                    Published=DateTime.UtcNow,
                    UserId=1

                },


            });


        }

    }
}
