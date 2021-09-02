using apiMarcaje.Context;
using apiMarcaje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiMarcaje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcajeController : ControllerBase
    {
        private readonly AppDbContext context;
        public MarcajeController(AppDbContext context) 
        {

            this.context = context;
        }

        // GET: api/<MarcajeController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.marcaje.ToList());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<MarcajeController>/5
        [HttpGet("{id}", Name ="GetMarcaje")]
        public ActionResult Get(int id)
        {
            try
            {
                var marcaje = context.marcaje.FirstOrDefault(f => f.Id_usuario == id);
                return Ok(marcaje);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<MarcajeController>
        [HttpPost]
        public ActionResult  Post([FromBody] Marcaje marcaje)
        {
            try
            {
                context.marcaje.Add(marcaje);
                context.SaveChanges();
                return CreatedAtRoute("GetMarcaje", new { id = marcaje.Id_usuario }, marcaje); 
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<MarcajeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Marcaje marcaje)
        {
            try
            {
                if (marcaje.Id_usuario == id)

                {
                    context.Entry(marcaje).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetMarcaje", new { id = marcaje.Id_usuario }, marcaje);

                }
                else 
                {
                    return BadRequest();
                }
            }

            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<MarcajeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var marcaje = context.marcaje.FirstOrDefault(f => f.Id_usuario == id);
                if (marcaje != null)
                {
                    context.marcaje.Remove(marcaje);
                    context.SaveChanges();
                    return Ok(id);
                }
                else 
                {
                 return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
