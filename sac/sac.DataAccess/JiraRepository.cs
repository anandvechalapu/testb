using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Sac.DTO.JIRA;

namespace Sac
{
    public class JiraRepository
    {
        private readonly string _connectionString;

        public JiraRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Jira GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Jira WHERE Id = @Id", connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Jira
                        {
                            Id = (int)reader["Id"]
                        };
                    }
                }
            }

            return null;
        }

        public IEnumerable<Jira> GetAll()
        {
            var jiras = new List<Jira>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Jira", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jiras.Add(new Jira
                        {
                            Id = (int)reader["Id"]
                        });
                    }
                }
            }

            return jiras;
        }

        public void Insert(Jira jira)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Jira (Id) VALUES (@Id)", connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = jira.Id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Jira jira)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Jira SET Id = @Id WHERE Id = @Id", connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = jira.Id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Jira WHERE Id = @Id", connection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}