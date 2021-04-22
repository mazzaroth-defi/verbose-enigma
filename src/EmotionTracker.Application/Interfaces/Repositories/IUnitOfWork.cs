using EmotionTracker.Domain.Contracts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAsync<T> Repository<T>() where T : AuditableEntity;

        Task<int> Commit(CancellationToken cancellationToken);

        Task Rollback();
    }
}