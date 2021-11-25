using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman water = new Sportsman(new WalkState());
            water.IncreaseExerciseIntensity();
            water.Relax();
            water.Relax();
            Console.Read();
        }
    }
}
