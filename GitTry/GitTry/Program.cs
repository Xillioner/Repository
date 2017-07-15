using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string> { "Hello World", "Hello Everybody", "Hello my Dear friend" };
            Class_Hi c_Hi = new Class_Hi();
            c_Hi.Print(messages.FirstOrDefault(x=>x.StartsWith("H")));
            Console.Read();
        }

        
    }
}
