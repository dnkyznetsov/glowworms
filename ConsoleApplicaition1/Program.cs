using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicaition1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\gaz.txt");
            var closeList = new List<float>();

            foreach (var line in lines)
            {
                var closestr = line.Split(',')[7];
                var closeInt = float.Parse(closestr.Replace('.', ','));
                closeList.Add(closeInt);
            }
            var postiions = new List<int>();
            var prev = 0;
            foreach (var price in closeList)
            {
                var c = (int) price;
                if (c != prev)
                {
                    prev = c;

                }

            }
        }
    }


}
