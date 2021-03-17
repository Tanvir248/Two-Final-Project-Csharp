using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memo_Apps
{
    public static class AppSetting
    {
        public static string ConnectionString()
        {
            string constring = "datasource=localhost; username=root;password=; database=client";
                return constring;
        }
    }
}
