using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommonLibrary;
using WebApplication1.CONTEXT;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotizsController : ControllerBase
    {
        private readonly NotizDbContext _context;

        public NotizsController(NotizDbContext context)
        {
            _context = context;
        }

  

        // GET: api/Notizs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notiz>>> GetNotiz()
        {
            return await _context.Notiz.ToListAsync();
        }

    

        // GET: api/Notizs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Notiz>> GetNotiz(int id)
        {
            var notiz = await _context.Notiz.FindAsync(id);

            if (notiz == null)
            {
                return NotFound();
            }

            return notiz;
        }

        // PUT: api/Notizs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
<<<<<<< HEAD

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotiz(int id, Notiz updatedNotiz)
        {
            var letezo = await _context.Notiz.FindAsync(id);
            if (letezo == null)
                return NotFound();

            // Frissítsd a mezőket
            letezo.Tulajdonos = updatedNotiz.Tulajdonos;
            letezo.Feladat = updatedNotiz.Feladat;
            letezo.Allapot = updatedNotiz.Allapot;
            letezo.MikorKezdje = updatedNotiz.MikorKezdje;
            letezo.HatarIdo = updatedNotiz.HatarIdo;
            letezo.FOntossag = updatedNotiz.FOntossag;
            letezo.Komment = updatedNotiz.Komment;
            letezo.ProjektNev = updatedNotiz.ProjektNev;

            await _context.SaveChangesAsync();
            return NoContent();
        }


        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNotiz(int id, Notiz notiz)
        //{
        //    if (id != notiz.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(notiz).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NotizExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}







=======
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotiz(int id, Notiz notiz)
        {
            if (id != notiz.ID)
            {
                return BadRequest();
            }

            _context.Entry(notiz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotizExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

>>>>>>> 77e9493cf3178d8d3a8f0caa0ca881dd3428a93b
        // POST: api/Notizs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Notiz>> PostNotiz(Notiz notiz)
        {
            _context.Notiz.Add(notiz);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNotiz", new { id = notiz.ID }, notiz);
        }

        // DELETE: api/Notizs/5
       

        private bool NotizExists(int id)
        {
            return _context.Notiz.Any(e => e.ID == id);
        }
    }
}
