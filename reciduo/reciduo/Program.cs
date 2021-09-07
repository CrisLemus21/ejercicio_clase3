using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reciduo.negocio;

namespace reciduo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsLogica clsLogica = new ClsLogica();
            Console.WriteLine(clsLogica.por());
            Console.ReadLine();
        }
    }
}
