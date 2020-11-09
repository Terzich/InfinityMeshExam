using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.ViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime Published { get; set; }
        public int UserId { get; set; }
    }
}
