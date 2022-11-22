﻿using Canopee.Application;
using Canopee.Common.DataTransferObjects;

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
            return Ok();
        }

        [HttpPost]
        public IActionResult AddTree(AddTreeDto tree)
        {
            var createdTree = _treeService.AddTree(tree);
            return CreatedAtRoute("GetTreeById", new { id = createdTree.Id }, createdTree);
        }
    }
}
