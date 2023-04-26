using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Sac.DTO.JIRA;
using Sac.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Sac.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        private JiraService _jiraService;

        public JiraController(string connectionString)
        {
            _jiraService = new JiraService(connectionString);
        }

        [HttpGet]
        public IEnumerable<Jira> GetAll()
        {
            return _jiraService.GetAll();
        }

        [HttpGet("{id}")]
        public Jira GetById(int id)
        {
            return _jiraService.GetById(id);
        }

        [HttpPost]
        public void Insert(Jira jira)
        {
            _jiraService.Insert(jira);
        }

        [HttpPut]
        public void Update(Jira jira)
        {
            _jiraService.Update(jira);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _jiraService.Delete(id);
        }

    }
}