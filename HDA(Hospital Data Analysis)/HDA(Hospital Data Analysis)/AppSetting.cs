using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDA_Hospital_Data_Analysis_
{
    public static class Appsetting
    {
        public static string ConnectionString()
        {
            string constring = "datasource=localhost; username=root;password=; database=medanalysis";
        
            return constring;
        }
    }
   
}
