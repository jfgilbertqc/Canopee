using Canopee.Domain.Contracts;
using Canopee.Domain.Entities;
using Canopee.Domain.Exceptions;

namespace Canopee.Persistence
{
    public class TreeRepository : RepositoryBase<Tree>, ITreeRepository
    {
        public TreeRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IList<Tree> GetTrees()
        {
            return FindAll(false).OrderBy(x => x.NameFr).ToList();
        }
        public void Add(Tree tree)
        {
            Create(tree);
        }

        public Tree GetTree(int id)
        {
            return FindByCondition(x => x.Id == id, false).SingleOrDefault();
        }

        public void Delete(int id)
        {
            var tree = GetTree(id);
            if (tree != null)
            {
                Delete(GetTree(id));
            }
            else
            {
                throw new EntityNotFoundException();
            }
        }
    }
}
