using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsProject
{
    public class Class1
    {
       
        public void Add(int i,int j)
        {
            int ans = i + j;
            Console.WriteLine(ans);
        }

        public void Sub(int i,int j)
        {
            int ans = i - j;
            Console.WriteLine("Sub:"+ans);
        }

        public void Multiply(int i,int j)
        {
            int ans = i * j;
            Console.WriteLine("Multiplication:"+ans);
        }

        public void Div(int i, int j)
        {
            int ans = i / j;
            Console.WriteLine("Multiplication:" + ans);
        }
    }
}
