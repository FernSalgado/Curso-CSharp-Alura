using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] familias = new string[3][];
            familias[0] = new string[] {"Fred","Ana","Vitor"};
            familias[1] = new string[] { "Fernando","Letícia","Paçoca","Dinha" };
            familias[2] = new string[] {"Maria"};

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(", ",familia));
            }
        }

    }
}
