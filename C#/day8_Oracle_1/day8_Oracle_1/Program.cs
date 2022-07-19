using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace day8_Oracle_1
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                // string constr = "Data source = ORCL;User Id = sys as sysdba;Password = #Oracle2022;";
                string constr = "Data source = (DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = sys as sysdba;Password = #Oracle2022;";
                OracleConnection con = new OracleConnection(constr);
                con.Open();

                OracleCommand cmd = new OracleCommand("getDept", con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter output = cmd.Parameters.Add("refcur_ret", OracleDbType.Ref);
                output.Direction = ParameterDirection.ReturnValue;

                OracleParameter input = cmd.Parameters.Add("deptno", OracleDbType.Int16);
                input.Direction = ParameterDirection.ReturnValue;
                input.Value = 10;

                cmd.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();

                Console.Write(reader.GetName(0) + "\t");
                Console.WriteLine(reader.GetName(1));
                Console.WriteLine("---------------");



            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
