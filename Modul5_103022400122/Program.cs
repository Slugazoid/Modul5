using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022400122
{
    public class SimpleDataBase<T>
    {
        private T storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase(T storedData)
        {
            this.storedData = storedData;
        }
        public void AddNewData<T>(T storedData) 
        { 

        }
        public void PrintAllData()
        {
            Console.WriteLine(this.storedData.ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
