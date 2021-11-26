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
            TransitionTo(ws);
        }

        public void TransitionTo(SportsmanState state)
        {
            State = state;
            State.SetContext(this);

        }

        public void IncreaseExerciseIntensity()
        {
            if (State.GetType() == typeof(StoodState))
            {
                Console.WriteLine("Ходьба");
                State.StateWalk(this);
            }
            else if (State.GetType() == typeof(WalkState))
            {
                Console.WriteLine("Починаєм біг");
                State.StateRun(this);
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
                State.StateWalk(this);
            }
            else if (State.GetType() == typeof(WalkState))
            {
                Console.WriteLine("Зупинились відпочити");
                State.StateStood(this);
            }
            else if (State.GetType() == typeof(StoodState))
            {
                Console.WriteLine("Ще постоїм");
            }
        }
    }

}
