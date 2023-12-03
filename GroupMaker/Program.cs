using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GroupMaker
{
    public class Program
    {
        // csoport db szám, nevek.. (idézőjelben szóközzel elválasztva)
        static void Main(string[] args)
        {
            string[] students= args.ToList().Skip(1).ToArray();
            int count = Convert.ToInt32(args[0]);

            GroupService
                .MakeOf(students)
                .In(count)
                .Print();

            Console.ReadKey();
        }
    }
}
