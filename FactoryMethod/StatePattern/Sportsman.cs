using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Sportsman
    {
        public SportsmanState State { get; set; }
        public Sportsman(SportsmanState ws)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            State = ws;
        }
        public void IncreaseExerciseIntensity()
        {
            if (State.GetType() == typeof(StoodState))
            {
                Console.WriteLine("Ходьба");
                State = new WalkState();
            }
            else if (State.GetType() == typeof(WalkState))
            {
                Console.WriteLine("Починаєм біг");
                State = new RunState();
            }
            else if (State.GetType() == typeof(RunState))
            {
                Console.WriteLine("Ми уже і так біжим");
            }
        }
        public void Relax()
        {
            if (State.GetType() == typeof(RunState))
            {
                Console.WriteLine("Зменшуєм темп бігу до ходьби");
                State = new WalkState();
            }
            else if (State.GetType() == typeof(WalkState))
            {
                Console.WriteLine("Зупинились відпочити");
                State = new StoodState();
            }
            else if (State.GetType() == typeof(StoodState))
            {
                Console.WriteLine("Ще постоїм");
            }
        }
    }

}
