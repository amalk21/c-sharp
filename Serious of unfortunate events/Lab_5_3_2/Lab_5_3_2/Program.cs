using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("usr1", 1);
            d.Add("usr2", 2);
            d.Add("usr3", 3);
            d.Add("usr4", 4);
            d.Add("usr5", 5);
            d.Add("usr6", 6);

            // get keys
            var val = d.Keys.ToList();

            // sort
            val.Sort();

            // displaying sorted keys
            foreach (var key in val)
            {
                Console.WriteLine(key);
            }
        }
    }
}
