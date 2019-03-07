using System;

namespace datebase_1
{
    public class DbCommand
    {
        private DBconnection _dbcon;
        private string _command;

        public DbCommand(DBconnection dbcon, string command)
        {
            if (dbcon == null || string.IsNullOrEmpty(command))
            {
                throw new Exception("Connection or command is null or empty");
            }
            else
            {
                _dbcon = dbcon;
                _command = command;
            }

        }

        public void Execute()
        {
            _dbcon.OpenConnection();
            Console.WriteLine("Execituing command is: {0}", _command);
            _dbcon.CloseConnection();
        }
    }
}
