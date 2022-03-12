using System;
using Whatever; // Namespace using in DLL

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Function created in DLL
            Whatever.HelloWorld.Print();
        }
    }
}