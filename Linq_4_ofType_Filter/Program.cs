using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_4_ofType_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> demodata = new List<object>() { "Manish", "Kumar", "Sharma", "JO", 1, 4, 7 };
            var use_of_oftype_filter = demodata.OfType<string>().ToList();

            var use_of_oftype_filter_with_where = demodata.OfType<string>().Where(x=>x.Length > 3).ToList();


            foreach (var item in use_of_oftype_filter_with_where)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
