using System;

namespace CHomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iPhone iphone = new iPhone();
            iphone.Memory = 256;
            iphone.Ram= 8;
            iphone.Price = 1500;

            Samsung samsung= new Samsung();
            samsung.Memory = 512;
            samsung.Ram = 16;
            samsung.Price= 1850;

            iphone.OperationSystem();
            samsung.OperationSystem();

        }
    }
}
