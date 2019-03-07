using System;

namespace datebase_1
{
    public class OracleConnection : DBconnection
    {
        readonly DateTime _endTime;

        public OracleConnection(string connectionString) : base(connectionString)
        {
            _endTime = DateTime.Now.AddSeconds(_TimeOut.Seconds);
            Console.WriteLine("OracleConnection Initialized...\n");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle datebase connection is closed");
        }

        public override void OpenConnection()
        {
            if (_endTime >= DateTime.Now)
                Console.WriteLine("Oracle Connection Opened");
            else
                throw new Exception("Connection Time out.");
        }
    }
}
