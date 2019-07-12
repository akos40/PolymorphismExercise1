using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise1
{

    class Program
    {
        static void Main(string[] args)
        {
            DbCommand dbCommand1 = new DbCommand(new SqlConnection("SQL Connection"), "hi");
            dbCommand1.Execute();

            DbCommand dbCommand2 = new DbCommand(new OracleConnecton("Oracle Connection"), "hy");
            dbCommand2.Execute();
        }
    }
}
