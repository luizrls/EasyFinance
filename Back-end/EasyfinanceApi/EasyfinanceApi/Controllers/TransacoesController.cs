using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EasyfinanceApi.Data;
using EasyfinanceApi.Model;

namespace EasyfinanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacoesController : ControllerBase
    {
        private readonly EasyfinanceApiContext _context;

        public TransacoesController(EasyfinanceApiContext context)
        {
            _context = context;
        }

        // GET: api/Transacoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transacoes>>> GetTransacao()
        {
            return await _context.Transacao.ToListAsync();
        }

        // GET: api/Transacoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transacoes>> GetTransacoes(int id)
        {
            var transacoes = await _context.Transacao.FindAsync(id);

            if (transacoes == null)
            {
                return NotFound();
            }

            return transacoes;
        }

        // PUT: api/Transacoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransacoes(int id, Transacoes transacoes)
        {
            if (id != transacoes.id)
            {
                return BadRequest();
            }

            _context.Entry(transacoes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransacoesExists(id))
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

        // POST: api/Transacoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transacoes>> PostTransacoes(Transacoes transacoes)
        {
            _context.Transacao.Add(transacoes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransacoes", new { id = transacoes.id }, transacoes);
        }

        // DELETE: api/Transacoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transacoes>> DeleteTransacoes(int id)
        {
            var transacoes = await _context.Transacao.FindAsync(id);
            if (transacoes == null)
            {
                return NotFound();
            }

            _context.Transacao.Remove(transacoes);
            await _context.SaveChangesAsync();

            return transacoes;
        }

        private bool TransacoesExists(int id)
        {
            return _context.Transacao.Any(e => e.id == id);
        }
    }
}
