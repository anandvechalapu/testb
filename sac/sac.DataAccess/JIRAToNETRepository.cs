using SAC.DTO;

namespace SAC
{
    public class JIRAToNETRepository : IJIRAToNETRepository
    {
        // Get All Records
        public async Task<IEnumerable<JIRAToNETModel>> GetAllRecordsAsync()
        {
            // Logic Implementation Here
        }
        
        // Get Record By Id
        public async Task<JIRAToNETModel> GetRecordByIdAsync(int id)
        {
            // Logic Implementation Here
        }

        // Create Record
        public async Task<bool> CreateRecordAsync(JIRAToNETModel model)
        {
            // Logic Implementation Here
        }

        // Update Record
        public async Task<bool> UpdateRecordAsync(JIRAToNETModel model)
        {
            // Logic Implementation Here
        }

        // Delete Record
        public async Task<bool> DeleteRecordAsync(int id)
        {
            // Logic Implementation Here
        }
    }
}