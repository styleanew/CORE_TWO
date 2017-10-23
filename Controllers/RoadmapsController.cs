using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TWO.Models;

namespace TWO.Controllers
{
    [Produces("application/json")]
    [Route("api/Roadmaps")]
    public class RoadmapsController : Controller
    {
        private readonly RoadmapContext _context;

        public RoadmapsController(RoadmapContext context)
        {
            _context = context;
        }

        // GET: api/Roadmaps
        [HttpGet]
        public IEnumerable<Roadmaps> GetRoadmaps()
        {
            return _context.Roadmaps;
        }

        // GET: api/Roadmaps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoadmaps([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roadmaps = await _context.Roadmaps.SingleOrDefaultAsync(m => m.Roadmapid == id);

            if (roadmaps == null)
            {
                return NotFound();
            }

            return Ok(roadmaps);
        }

        // PUT: api/Roadmaps/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoadmaps([FromRoute] int id, [FromBody] Roadmaps roadmaps)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != roadmaps.Roadmapid)
            {
                return BadRequest();
            }

            _context.Entry(roadmaps).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoadmapsExists(id))
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

        // POST: api/Roadmaps
        [HttpPost]
        public async Task<IActionResult> PostRoadmaps([FromBody] Roadmaps roadmaps)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Roadmaps.Add(roadmaps);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoadmapsExists(roadmaps.Roadmapid))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoadmaps", new { id = roadmaps.Roadmapid }, roadmaps);
        }

        // DELETE: api/Roadmaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoadmaps([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roadmaps = await _context.Roadmaps.SingleOrDefaultAsync(m => m.Roadmapid == id);
            if (roadmaps == null)
            {
                return NotFound();
            }

            _context.Roadmaps.Remove(roadmaps);
            await _context.SaveChangesAsync();

            return Ok(roadmaps);
        }

        private bool RoadmapsExists(int id)
        {
            return _context.Roadmaps.Any(e => e.Roadmapid == id);
        }
    }
}