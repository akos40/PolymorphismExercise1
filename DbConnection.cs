using System;

namespace PolymorphismExercise1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString == "")
            {
                throw new Exception("A kapcsolat nem lehet null vagy ures");
            }
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();

    }
}
