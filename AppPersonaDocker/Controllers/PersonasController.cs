using AppPersonaDocker.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppPersonaDocker.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly AppDbContext context;
        public PersonasController(AppDbContext _context)
        {
            this.context = _context;
        }


        // GET: api/<PersonasController>
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return context.Persona.ToList();
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public Persona Get(int id)
        {
            return context.Persona.Find(id);
        }

        // POST api/<PersonasController>
        [HttpPost]
        public void Post(Persona  persona)
        {
            context.Persona.Add(persona);
            context.SaveChanges();
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var persona = context.Persona.Find(id);
            if (persona != null)
            {
                context.Persona.Remove(persona);
                context.SaveChanges();
            }
        }
    }
}
