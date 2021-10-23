using System;
using OOP_Principles.SingleResponsibility_DependencyInversion;
using OOP_Principles.Open_Closed.ConnectionRefactored;
namespace OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentRefactored a;
            VerifyPriceRefactored s = new VerifyPriceRefactored();
            VerifyPriceService t = new VerifyPriceService();
            a = new ComponentRefactored("cpu", 2500);
            // Single Responsibility
            Console.WriteLine(a.verifyPrice(2400));
            // Single Responsibility + Dependency Inversion
            Console.WriteLine(a.verifyPriceRefactored(2400, s));
            Console.WriteLine(a.verifyPriceRefactored(2400, t));

            Device d1, d2, d3;
            ConnectionServiceRefactored service = new ConnectionServiceRefactored(); //only for the sake of this example
            d1 = new PhotoCameraRefactored("photo camera", 200);
            d2 = new VideoCameraRefactored("video camera", 50);
            d3 = new Mouse("mouse", 2400);
            Console.WriteLine(service.isConnected(d1));
            Console.WriteLine(service.isConnected(d2));
            Console.WriteLine(service.isConnected(d3));
        }
    }
}
