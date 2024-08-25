using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace samaul
{
 
    internal class Calculetor
    {
        int x;
        int y;
        public int result=0;
        public void add(int x, int y)
        {
            result = x + y;
        }
        public void sub(int x, int y)
        {
            result = x - y;
        }
        public void mul(int x, int y)
        {
            result = x * y;
        }
        public void div (int x, int y)
        {
            result = x / y;
        }
        public void mod(int x, int y)
        {
            result = x % y;
        }
        public void seeResult() 
        {
            Console.WriteLine($"Result : {result}");
        }
       
    }
}
