using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FiapChallange.Lunai.InfraData.Context
{
    public class MysqlContext : IDisposable
    {
        public MySqlConnection Connection { get; set; }
        private IConfiguration _configuracoes;

        public MysqlContext(IConfiguration configuration) 
        {
            this._configuracoes = configuration;
            Connection = new MySqlConnection(_configuracoes.GetConnectionString("Mysql"));
            Connection.Open();
        }
        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
