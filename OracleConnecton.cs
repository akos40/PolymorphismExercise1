namespace PolymorphismExercise1
{
    public class OracleConnecton : DbConnection
    {
        public OracleConnecton(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            System.Console.WriteLine("Closing Oracle Connection...");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening Oracle Connection");
        }
    }
}
