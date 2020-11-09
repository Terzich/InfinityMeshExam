using AutoMapper;
using InfinityMeshExam.DAL.Database;
using InfinityMeshExam.DAL.Domain;
using InfinityMeshExam.DAL.Requests;
using InfinityMeshExam.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Repository
{
    public class SqlServerBlogRepository : BaseRepository<BlogViewModel, BlogUpsertRequest, Blog>
    {
        public SqlServerBlogRepository(InfinityMeshExamDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
