using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HDA_Hospital_Data_Analysis_.Model;
using MySql.Data.MySqlClient;

namespace HDA_Hospital_Data_Analysis_.Model
{
    public class Diseas : ModelBase
    {

        public Diseas() : base("diseases")
        {
            
        }

        public int admitted(string dieseas_id, string record_id)
        {
            int totalAdmit = 0;
            int totalRecovery = 0;
            int totalDeath = 0;
            Record record = new Record();
            MySqlDataReader reader = this.execute("SELECT * FROM records WHERE diseas_id="+dieseas_id+" AND id<="+record_id);

            while (reader.Read())
            {
                totalAdmit += int.Parse(reader[2].ToString());
                totalRecovery += int.Parse(reader[3].ToString());
                totalDeath += int.Parse(reader[4].ToString());
            }

            return totalAdmit - totalRecovery - totalDeath;
        }

    }
}
