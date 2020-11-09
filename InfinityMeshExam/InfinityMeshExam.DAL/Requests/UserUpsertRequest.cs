using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Requests
{
    public class UserUpsertRequest
    {
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public string Email { get; set; }
        public int NumberOfBlogs { get; set; }
        public string ViewProfile { get; set; }
    }
}
