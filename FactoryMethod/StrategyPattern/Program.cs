using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Paint paint = new Paint();
            Stick stick = new Stick();
            Expert expert = new Expert("Ivan", stick);
            expert.DoSomeWork();
            expert = new Expert("Vasil", paint);
            expert.DoSomeWork();
        }
    }
}
