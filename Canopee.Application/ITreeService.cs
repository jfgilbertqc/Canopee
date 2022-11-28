using Canopee.Common.DataTransferObjects;

namespace Canopee.Application
{
    public interface ITreeService
    {
        public IList<TreeDto> GetTrees();
        public TreeDto AddTree(AddTreeDto tree);
        TreeDto GetTree(int id);
        void Delete(int id);
    }
}
