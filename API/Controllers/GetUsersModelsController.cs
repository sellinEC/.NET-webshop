using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUsersModelsController : ControllerBase
    {
        private readonly SqlContext _context;

        public GetUsersModelsController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/GetUsersModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUsersModel>>> GetGetUsersModel()
        {
            return await _context.GetUsersModel.ToListAsync();
        }

        // GET: api/GetUsersModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetUsersModel>> GetGetUsersModel(int id)
        {
            var getUsersModel = await _context.GetUsersModel.FindAsync(id);

            if (getUsersModel == null)
            {
                return NotFound();
            }

            return getUsersModel;
        }

        // PUT: api/GetUsersModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGetUsersModel(int id, GetUsersModel getUsersModel)
        {
            if (id != getUsersModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(getUsersModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GetUsersModelExists(id))
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

        // POST: api/GetUsersModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GetUsersModel>> PostGetUsersModel(GetUsersModel getUsersModel)
        {
            _context.GetUsersModel.Add(getUsersModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGetUsersModel", new { id = getUsersModel.Id }, getUsersModel);
        }

        // DELETE: api/GetUsersModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGetUsersModel(int id)
        {
            var getUsersModel = await _context.GetUsersModel.FindAsync(id);
            if (getUsersModel == null)
            {
                return NotFound();
            }

            _context.GetUsersModel.Remove(getUsersModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GetUsersModelExists(int id)
        {
            return _context.GetUsersModel.Any(e => e.Id == id);
        }
    }
}
