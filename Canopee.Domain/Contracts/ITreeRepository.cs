using Canopee.Domain.Entities;

namespace Canopee.Domain.Contracts
{
    public interface ITreeRepository
    {
        public IList<Tree> GetTrees();
    }
}
