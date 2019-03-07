using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datebase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlCon = new SqlConnection("SQLConnectionString");
            var oracleCon = new OracleConnection("ORACLEConnectionString");
            //Exercise 1
            try
            {
                sqlCon.OpenConnection();
                sqlCon.CloseConnection();

                oracleCon.OpenConnection();
                oracleCon.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("---------------------\n\n");
            //Exercise 2
            var dbCommandSql = new DbCommand(sqlCon, "Select from SQL");

            var dbCommandOracle = new DbCommand(oracleCon, "Select from ORACLE");

            try
            {
                dbCommandSql.Execute();
                dbCommandOracle.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
