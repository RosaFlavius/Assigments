using CreationalDP;
using System;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingletoneForFactory.Instance.CreateQuote();
        }
    }
}