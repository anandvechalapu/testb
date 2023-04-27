using SAC.DTO;

namespace SAC.Service
{
    public interface IJIRAToNETRepository
    {
        // Get All Records
        Task<IEnumerable<JIRAToNETModel>> GetAllRecordsAsync();

        // Get Record By Id
        Task<JIRAToNETModel> GetRecordByIdAsync(int id);

        // Create Record
        Task<bool> CreateRecordAsync(JIRAToNETModel model);

        // Update Record
        Task<bool> UpdateRecordAsync(JIRAToNETModel model);

        // Delete Record
        Task<bool> DeleteRecordAsync(int id);
    }
}