﻿using Canopee.Domain.Contracts;
using Canopee.Domain.Entities;

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
    }
}
