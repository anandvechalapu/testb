namespace sac.Service
{
    using sac.DTO;

    public interface IJiraToNetService
    {
        Task<JiraToNetModel> GetJiraToNetAsync(int id);
        Task<IEnumerable<JiraToNetModel>> GetJiraToNetsAsync();
        Task<JiraToNetModel> AddJiraToNetAsync(JiraToNetModel jiraToNet);
        Task<JiraToNetModel> UpdateJiraToNetAsync(JiraToNetModel jiraToNet);
        Task DeleteJiraToNetAsync(int id);
    }
}