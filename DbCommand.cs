using System;

namespace PolymorphismExercise1
{
    public class DbCommand
    {
        public DbConnection _dbConnection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(dbConnection == null)
            {
                throw new System.Exception("Cannot be null");
            }
            _dbConnection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Instruction");
            _dbConnection.Close();
        }
    }
}
