namespace SAC.Service
{
    public class JIRAToNETService : IJIRAToNETService 
    {
        private readonly IJIRAToNETRepository _jiraToNETRepository;
        private readonly SACDataAccess _dataAccess;

        public JIRAToNETService(IJIRAToNETRepository jiraToNETRepository,
            SACDataAccess dataAccess)
        {
            _jiraToNETRepository = jiraToNETRepository;
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<JIRAToNETModel>> GetAllRecordsAsync()
        {
            return await _jiraToNETRepository.GetAllRecordsAsync();
        }

        public async Task<JIRAToNETModel> GetRecordByIdAsync(int id)
        {
            return await _jiraToNETRepository.GetRecordByIdAsync(id);
        }

        public async Task<bool> CreateRecordAsync(JIRAToNETModel model)
        {
            return await _jiraToNETRepository.CreateRecordAsync(model);
        }

        public async Task<bool> UpdateRecordAsync(JIRAToNETModel model)
        {
            return await _jiraToNETRepository.UpdateRecordAsync(model);
        }

        public async Task<bool> DeleteRecordAsync(int id)
        {
            return await _jiraToNETRepository.DeleteRecordAsync(id);
        }
    }
}