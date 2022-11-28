using Canopee.Application;
using Canopee.Common.DataTransferObjects;
using Canopee.Domain.Exceptions;

using Microsoft.AspNetCore.Mvc;

namespace Canopee.Web.Controllers
{
    [Route("api/trees")]
    [ApiController]
    public class TreesController : ControllerBase
    {
        private ITreeService _treeService;
        public TreesController(ITreeService treeService)
        {
            _treeService = treeService;
        }

        [HttpGet]
        public IActionResult GetTrees()
        {
            return Ok(_treeService.GetTrees());
        }

        [HttpGet("{id:int}", Name = "GetTreeById")]
        public IActionResult GetTreeById(int id)
        {
            var tree = _treeService.GetTree(id);
            return tree != null ? Ok(tree) : NotFound();
        }

        [HttpDelete("{id:int}", Name = "Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                _treeService.Delete(id);
                return NoContent();
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddTree(AddTreeDto tree)
        {
            var createdTree = _treeService.AddTree(tree);
            return CreatedAtRoute("GetTreeById", new { id = createdTree.Id }, createdTree);
        }
    }
}
