using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedoLivro
{
    static class funcoes
    {
        public static string FormatarData(DateTime dt )
        {
            return dt.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static void pulalinha()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
    }
}
