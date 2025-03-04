using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace basicPointOfSalesSoftware.General
{
    public class ApplicationSetting
    {
        public static string ConnectionStrin()
        {
            
                return ConfigurationManager.ConnectionStrings["basicPointOfSalesSoftware.Properties.Settings.Setting"].ConnectionString;
           

        }
    }
}