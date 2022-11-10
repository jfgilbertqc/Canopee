using Canopee.Domain.Contracts;
using Canopee.Domain.Entities;

namespace Canopee.Persistence
{
    public class TreeRepository : RepositoryBase<Tree>, ITreeRepository
    {
        public TreeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IList<Tree> GetTrees()
        {
            return new List<Tree>();
        }


    }
}
