using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HDA_Hospital_Data_Analysis_.Model
{
    public class ModelBase
    {
        string table;

        public ModelBase(string table)
        {
            this.table = table;
        }

        public MySqlDataReader execute(string query)
        {
            MySqlConnection conn = new MySqlConnection(Appsetting.ConnectionString());
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void insert(string cols, string values)
        {
            MySqlDataReader reader = this.execute("INSERT INTO "+this.table+" ("+cols+") VALUES (" + values + ")");
        }

        public void update(string condition, string values)
        {
            MySqlDataReader reader = this.execute("UPDATE " + this.table + " SET " + values + " WHERE " + condition);
        }

        public MySqlDataReader all()
        {
            return this.execute("SELECT * from "+this.table);
        }

        public MySqlDataReader where(string column, string value)
        {
            return this.execute("SELECT * from " + this.table + " where " + column + "='" + value+"'");
        }

        public MySqlDataReader last(string column, string value)
        {
            return this.execute("SELECT * FROM " + this.table + " WHERE "+column+"="+value+" ORDER BY ID DESC LIMIT 1");
        }
    }
}
