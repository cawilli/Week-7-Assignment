using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_Assignment
{
    public class Programming_Loops
    {
        public int ForEachLoop()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public void ForLoop()
        {
            var sum = 0;
            for (var i = 0; i < 100; i++)
            {
                sum = sum + i;
            }

        }
    }
}
