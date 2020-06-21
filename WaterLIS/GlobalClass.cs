using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace WaterLIS
{
    class GlobalClass
    {
        public static OleDbDataAdapter adap;
        public static OleDbCommandBuilder bui;
        public static DataTable dt;
        public static string total;
        public static string srno = "0";

    }
}