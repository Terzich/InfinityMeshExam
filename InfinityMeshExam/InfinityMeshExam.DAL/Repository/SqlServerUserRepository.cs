using AutoMapper;
using InfinityMeshExam.DAL.Database;
using InfinityMeshExam.DAL.Domain;
using InfinityMeshExam.DAL.Requests;
using InfinityMeshExam.DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshExam.DAL.Repository
{
    public class SqlServerUserRepository : BaseRepository<UserViewModel, UserUpsertRequest, User>
    {
        public SqlServerUserRepository(InfinityMeshExamDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<List<UserViewModel>> GetAll(string search, CancellationToken cancellationToken = default)
        {
            var query = _context.Set<User>().AsQueryable();
            if(!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(q => q.Name == search || q.Email == search);
            }
            var list = await query.ToListAsync();
            var result= _mapper.Map<List<UserViewModel>>(list);
            return result;
        }
    }
}
