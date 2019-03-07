using System;

namespace datebase_1
{
    public class SqlConnection : DBconnection
    {
        readonly DateTime _endTime;
        public SqlConnection(string connectionString): base(connectionString)
        {
            _endTime = DateTime.Now.AddSeconds(_TimeOut.Seconds);
            Console.WriteLine("Sql connection initialized...");
        }

        
        public override void CloseConnection()
        {
            Console.WriteLine("Sql datebase connection is closed" );
        }

        public override void OpenConnection()
        {
            if (_endTime >= DateTime.Now)
            {
                Console.WriteLine("Sql datebase connection is opened");
            }
            else
            {
                throw new Exception("Connection Timeout");
            }
        }
    }
}
