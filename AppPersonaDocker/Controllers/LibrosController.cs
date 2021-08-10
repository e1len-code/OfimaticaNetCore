using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPersonaDocker.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppPersonaDocker.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly AppDbContext context;
        public LibrosController(AppDbContext _context)
        {
            this.context = _context;
        }


        // GET: api/<LibrosController>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return context.Libro.ToList();
        }

        // GET api/<LibrosController>/5
        [HttpGet("{id}")]
        public Libro Get(int id)
        {
            return context.Libro.Find(id);
        }

        // POST api/<LibrosController>
        [HttpPost]
        public void Post(Libro libro)
        {
            context.Libro.Add(libro);
            context.SaveChanges();
        }

        // PUT api/<LibrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var libro = context.Libro.Find(id);
            if (libro != null)
            {
                context.Libro.Remove(libro);
                context.SaveChanges();
            }
        }
    }
}
