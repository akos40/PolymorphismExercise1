namespace PolymorphismExercise1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            System.Console.WriteLine("Closing SQL Connection...");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening SQL Connection...");
        }
    }
}
