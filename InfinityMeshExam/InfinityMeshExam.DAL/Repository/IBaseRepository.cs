using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfinityMeshExam.DAL.Repository
{
    public interface IBaseRepository<TModel,TUpsertRequest>
    {
        Task<List<TModel>> GetAll(string search,CancellationToken cancellationToken = default);
        Task<TModel> GetById(int id, CancellationToken cancellationToken = default);
        Task<int> Save(TUpsertRequest obj, CancellationToken cancellationToken = default);
        Task Update(int id, TUpsertRequest obj, CancellationToken cancellationToken = default);
        Task Remove(int id, CancellationToken cancellationToken = default);
    }
}
