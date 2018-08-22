using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Message welcome = new Message(new RealDateTime()); // 
                Console.WriteLine(welcome.GetHelloMessage()); // appelle la méthode GetHelloMessage() avec le RealDateTime

            } while (Console.ReadLine() != "exit");

        }
    }
}

