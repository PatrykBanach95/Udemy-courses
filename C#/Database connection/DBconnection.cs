using System;

namespace datebase_1
{
    public abstract class DBconnection
    {
        string _ConnectionString;
        public readonly TimeSpan _TimeOut = TimeSpan.FromSeconds(10) ;

        public DBconnection(string connectionstring)
        {
            if (string.IsNullOrEmpty(connectionstring))
            {
                throw new Exception("String is null or empty");
            }
            else
            {
                _ConnectionString = connectionstring;
            }
                     
        }
        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}
