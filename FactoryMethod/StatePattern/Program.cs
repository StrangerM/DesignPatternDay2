using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman sportsman = new Sportsman(new WalkState());
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
            sportsman.Relax();
            Console.Read();
        }
    }
}
