using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/task")]

    public class TaskController : ControllerBase
    {
        private readonly DataContext _context;

        public TaskController(DataContext context)
        {
            _context = context;
        }

        //POST: api/task/create
        [HttpPost]
        [Route("create")]

        public IActionResult Create([FromBody]TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Created("", task);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Tasks.ToList());

        //GET: api/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            //Buscar o produto pelo Id
            TaskModel task = _context.Tasks.Find(id);
            if(task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }
    }
}