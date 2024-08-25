using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samaul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);Console.WriteLine("samaul");
            //Console.WriteLine("lorem as;ldfja;lsdjfl;asjdf");
            //Console.WriteLine(10 * 20 * 10 + 6);
            Shihan shihanOnj = new Shihan();
            shihanOnj.Shihans();
            int num1;
            int num2;
            string calName;
            //create an a instand on claculatero class
            Calculetor calObj = new Calculetor();
            //user input num1 and num2
           
            while (true)
            {
                Console.WriteLine("how to calculate sum, sub, mul, div, mod and type exit then quit");
                calName = Console.ReadLine();
                if (calName == "exit")
                {
                    break;
                }
                if (calName == "sum" || calName == "sub" || calName == "mul" || calName == "div" || calName == "mod")
                {
                    Console.WriteLine("please Input num 1");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("please input num 2");
                    num2 = int.Parse(Console.ReadLine());
                    if (num1 == 0 || num2 == 0)
                    {
                        break;
                    }
                    switch (calName)
                    {
                        case "sum":
                            calObj.add(num1, num2);
                            break;
                        case "sub":
                            calObj.sub(num1, num2);
                            break;
                        case "mul":
                            calObj.mul(num1, num2);
                            break;
                        case "div":
                            calObj.div(num1, num2);
                            break;
                        case "mod":
                            calObj.mod(num1, num2);
                            break;
                        default:
                            Console.WriteLine("invalid Input");
                            break;
                    }
                    calObj.seeResult();
                }
                else {
                    Console.WriteLine("invalie input");
                }
                   

            }          

            Console.Read();
        }
    }
}
