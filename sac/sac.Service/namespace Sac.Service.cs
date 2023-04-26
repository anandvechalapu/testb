using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Sac.DTO.JIRA;
using Sac.DataAccess;

namespace Sac.Service
{
    public class JiraService
    {
        private JiraRepository _jiraRepository;

        public JiraService(string connectionString)
        {
            _jiraRepository = new JiraRepository(connectionString);
        }

        public Jira GetById(int id)
        {
            return _jiraRepository.GetById(id);
        }

        public IEnumerable<Jira> GetAll()
        {
            return _jiraRepository.GetAll();
        }

        public void Insert(Jira jira)
        {
            _jiraRepository.Insert(jira);
        }

        public void Update(Jira jira)
        {
            _jiraRepository.Update(jira);
        }

        public void Delete(int id)
        {
            _jiraRepository.Delete(id);
        }
    }
}