using Canopee.Domain.Entities;

namespace Canopee.Domain.Contracts
{
    public interface ITreeRepository
    {
        public IList<Tree> GetTrees();
        public void Add(Tree tree);
        Tree GetTree(int id);
    }
}
