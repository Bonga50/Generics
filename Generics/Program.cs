using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            Console.WriteLine(comp<int>(x, y));
            Console.WriteLine(comp<double>(x, y));
            Console.WriteLine(comp<string>("Hi", "hi"));
            Console.WriteLine(getLength<string,int>("33",2));
            

            
            Console.Read();
        }

        static bool comp<T>(T x,T y) 
        {
            if (x.GetType()==typeof(string))
            {
                return x.ToString().ToLower().Equals(y.ToString().ToLower());

            }
            return x.Equals(y);

        }
        static bool getLength<T1,T2>(T1 str,T2 length) {
            return str.ToString().Length.Equals(length);
        }

        //private static bool comp(string v1, string v2)
        //{
        //    return v1.Equals(v2);
        //}

        //private static bool comp(double x, double y)
        //{
        //    return x == y;
        //}

        //private static bool comp(int x, int y)
        //{
        //    return x == y;
        //}
    }
}
