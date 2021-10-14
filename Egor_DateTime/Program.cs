using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egor_DateTime.BaseElements;

namespace Egor_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new Date(10, 5, 2004);

            var secondDate = new Date(20, 5, 2004);

            date += 5;

            date.ShowDate();

            Console.WriteLine((secondDate - date).ToString());


            Console.ReadKey();
        }
    }
}
