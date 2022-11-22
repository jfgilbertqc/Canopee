﻿using AutoMapper;

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

        public TreeDto AddTree(AddTreeDto tree)
        {
            var mappedTree = _mapper.Map<Tree>(tree);
            _repositoryManager.TreeRepository.Add(mappedTree);
            _repositoryManager.Save();
            return _mapper.Map<TreeDto>(mappedTree);
        }

        public IList<TreeDto> GetTrees()
        {
            var trees = _repositoryManager.TreeRepository.GetTrees();
            return _mapper.Map<IList<TreeDto>>(trees);
        }
    }
}
