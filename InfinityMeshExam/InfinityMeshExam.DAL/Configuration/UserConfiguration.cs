using InfinityMeshExam.DAL.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Configuration
{
    public class UserConfiguration:BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasMany(b => b.Blogs).WithOne(b => b.User).HasForeignKey(b => b.UserId);


            builder.HasData(new List<User>
            {
                new User
                {
                    Id=1,
                    Name="Ahmed Terzic",
                    Age=new DateTime(1999,08,21),
                    Email="ahmedterzic@infinity.com",
                    NumberOfBlogs=0,
                    ViewProfile="www.infinitymesh.com/profile/ahmedterzic",
                },
                new User
                {
                    Id=2,
                    Name="Ajding Tabak",
                    Age=new DateTime(1998,01,25),
                    Email="ajdintabak@infinity.com",
                    NumberOfBlogs=0,
                    ViewProfile="www.infinitymesh.com/profile/ajdintabak",
                },
                new User
                {
                    Id=3,
                    Name="Husein Muftic",
                    Age=new DateTime(1999,11,21),
                    Email="huseinmuftic@infinity.com",
                    NumberOfBlogs=0,
                    ViewProfile="www.infinitymesh.com/profile/huseinmuftic",
                }

            });

        }
    }
}
