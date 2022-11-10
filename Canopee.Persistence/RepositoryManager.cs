using Canopee.Domain.Contracts;

namespace Canopee.Persistence
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ITreeRepository> _treeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _treeRepository = new Lazy<ITreeRepository>(() => new TreeRepository(_repositoryContext));
        }

        public ITreeRepository TreeRepository => _treeRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
