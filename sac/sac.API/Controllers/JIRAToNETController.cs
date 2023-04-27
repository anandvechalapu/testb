using SAC.API;
using SAC.DTO;
using SAC.Service;
using Microsoft.AspNetCore.Mvc;

namespace SAC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JIRAToNETController : ControllerBase
    {
        private readonly JIRAToNETService _jiraToNETService;

        public JIRAToNETController(JIRAToNETService jiraToNETService)
        {
            _jiraToNETService = jiraToNETService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JIRAToNETModel>>> GetAllRecordsAsync()
        {
            var records = await _jiraToNETService.GetAllRecordsAsync();
            return Ok(records);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JIRAToNETModel>> GetRecordByIdAsync(int id)
        {
            var record = await _jiraToNETService.GetRecordByIdAsync(id);
            if (record == null)
            {
                return NotFound();
            }

            return Ok(record);
        }

        [HttpPost]
        public async Task<ActionResult<JIRAToNETModel>> CreateRecordAsync([FromBody] JIRAToNETModel model)
        {
            var isSuccess = await _jiraToNETService.CreateRecordAsync(model);
            if (!isSuccess)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetRecordByIdAsync), new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecordAsync(int id, [FromBody] JIRAToNETModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var isSuccess = await _jiraToNETService.UpdateRecordAsync(model);
            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecordAsync(int id)
        {
            var isSuccess = await _jiraToNETService.DeleteRecordAsync(id);
            if (!isSuccess)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}