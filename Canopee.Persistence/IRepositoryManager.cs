using Canopee.Domain.Contracts;

namespace Canopee.Persistence
{
    public interface IRepositoryManager
    {
        public ITreeRepository TreeRepository { get; }
    }
}
