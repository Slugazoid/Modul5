using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022400122
{
    public class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T x, T y, T z)
        { 
            dynamic a = (dynamic)x;
            dynamic b = (dynamic)y;
            dynamic c = (dynamic)z;
            dynamic d = (dynamic)x;
            if(d < b)
            {
                d = b;
            }if (d < c)
            {
                d = c;
            }
            Console.WriteLine("Nilai terbesar adalah " + d);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PemrosesData data = new PemrosesData();
            data.DapatkanNilaiTerbesar<float>(10, 30, 22);


        }
    }
}
