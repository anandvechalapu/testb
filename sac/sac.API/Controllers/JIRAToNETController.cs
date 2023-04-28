using sac.DTO;
using sac.Service;
using Microsoft.AspNetCore.Mvc;

namespace sac.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JIRAToNETController : ControllerBase
    {
        private readonly JIRAToNETService _jIRAToNETService;

        public JIRAToNETController(JIRAToNETService jIRAToNETService)
        {
            _jIRAToNETService = jIRAToNETService;
        }

        // GET: api/JIRAToNET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JIRAToNETDTO>>> GetJIRAToNET()
        {
            return await _jIRAToNETService.GetJIRAToNET();
        }

        // GET: api/JIRAToNET/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JIRAToNETDTO>> GetJIRAToNET(int id)
        {
            var jIRAToNETDTO = await _jIRAToNETService.GetJIRAToNET(id);

            if (jIRAToNETDTO == null)
            {
                return NotFound();
            }

            return jIRAToNETDTO;
        }

        // PUT: api/JIRAToNET/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJIRAToNET(int id, JIRAToNETDTO jIRAToNETDTO)
        {
            if (id != jIRAToNETDTO.Id)
            {
                return BadRequest();
            }

            await _jIRAToNETService.UpdateJIRAToNET(jIRAToNETDTO);

            return NoContent();
        }

        // POST: api/JIRAToNET
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<JIRAToNETDTO>> PostJIRAToNET(JIRAToNETDTO jIRAToNETDTO)
        {
            await _jIRAToNETService.CreateJIRAToNET(jIRAToNETDTO);

            return CreatedAtAction("GetJIRAToNET", new { id = jIRAToNETDTO.Id }, jIRAToNETDTO);
        }

        // DELETE: api/JIRAToNET/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JIRAToNETDTO>> DeleteJIRAToNET(int id)
        {
            var jIRAToNETDTO = await _jIRAToNETService.GetJIRAToNET(id);
            if (jIRAToNETDTO == null)
            {
                return NotFound();
            }

            await _jIRAToNETService.DeleteJIRAToNET(jIRAToNETDTO);

            return jIRAToNETDTO;
        }
    }
}