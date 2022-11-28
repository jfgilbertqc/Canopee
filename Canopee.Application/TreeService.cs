using AutoMapper;

using Canopee.Common.DataTransferObjects;
using Canopee.Domain.Entities;
using Canopee.Persistence;

namespace Canopee.Application
{
    public class TreeService : ITreeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public TreeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public TreeDto GetTree(int id)
        {
            var tree = _repositoryManager.TreeRepository.GetTree(id);
            return tree != null ? _mapper.Map<Tree, TreeDto>(tree) : null;
        }

        public IList<TreeDto> GetTrees()
        {
            var trees = _repositoryManager.TreeRepository.GetTrees();
            return _mapper.Map<IList<TreeDto>>(trees);
        }

        public TreeDto AddTree(AddTreeDto tree)
        {
            var mappedTree = _mapper.Map<Tree>(tree);
            _repositoryManager.TreeRepository.Add(mappedTree);
            _repositoryManager.Save();
            return _mapper.Map<TreeDto>(mappedTree);
        }

        public void UpdateTree(UpdateTreeDto tree)
        {
            var mappedTree = _mapper.Map<Tree>(tree);
            _repositoryManager.TreeRepository.Update(mappedTree);
            _repositoryManager.Save();
        }

        public void Delete(int id)
        {
            _repositoryManager.TreeRepository.Delete(id);
            _repositoryManager.Save();
        }
    }
}
