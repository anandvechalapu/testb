namespace sac
{
    using sac.DTO;
    public interface IJiraToNetRepository
    {
        Task<JiraToNetModel> GetJiraToNetAsync(int id);
        Task<IEnumerable<JiraToNetModel>> GetJiraToNetsAsync();
        Task<JiraToNetModel> AddJiraToNetAsync(JiraToNetModel jiraToNet);
        Task<JiraToNetModel> UpdateJiraToNetAsync(JiraToNetModel jiraToNet);
        Task DeleteJiraToNetAsync(int id);
    }

    public class JiraToNetRepository : IJiraToNetRepository
    {
        public async Task<JiraToNetModel> GetJiraToNetAsync(int id)
        {
            // code to retrieve JiraToNetModel object
            return jiraToNet;
        }

        public async Task<IEnumerable<JiraToNetModel>> GetJiraToNetsAsync()
        {
            // code to retrieve all JiraToNetModel objects
            return jiraToNets;
        }

        public async Task<JiraToNetModel> AddJiraToNetAsync(JiraToNetModel jiraToNet)
        {
            // code to add JiraToNetModel object
            return jiraToNet;
        }

        public async Task<JiraToNetModel> UpdateJiraToNetAsync(JiraToNetModel jiraToNet)
        {
            // code to update JiraToNetModel object
            return jiraToNet;
        }

        public async Task DeleteJiraToNetAsync(int id)
        {
            // code to delete JiraToNetModel object
        }
    }
}