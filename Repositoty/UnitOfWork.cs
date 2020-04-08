using DataContextExampleCSharp.DataContexts;
using DataContextExampleCSharp.Models;
using System.Threading.Tasks;

namespace DataContextExampleCSharp.Repositoty
{
    public interface IUnitOfWork
    {
        ICommonRepository<CallExtractionProgress> CallExtractionProgressers { get; }
        Task CommitAsync();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext _dataContext;
        private CommonRepository<CallExtractionProgress> _callExtractionProgressers;

        public UnitOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICommonRepository<CallExtractionProgress> CallExtractionProgressers
        {
            get
            {
                return _callExtractionProgressers ?? (_callExtractionProgressers = new CommonRepository<CallExtractionProgress>(_dataContext));
            }
        }

        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
