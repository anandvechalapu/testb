using SAC.DTO;

namespace SAC.Service
{
    public interface IJIRAToNETService
    {
        Task<IEnumerable<JIRAToNETModel>> GetAllRecordsAsync();
        Task<JIRAToNETModel> GetRecordByIdAsync(int id);
        Task<bool> CreateRecordAsync(JIRAToNETModel model);
        Task<bool> UpdateRecordAsync(JIRAToNETModel model);
        Task<bool> DeleteRecordAsync(int id);
    }
}