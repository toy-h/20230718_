using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230718
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State[] states = new State[4];
            Transition[] transitions = new Transition[5];

            states[0] = new State();
            states[0].id = 1;
            states[0].stateName = "배회";
            states[1] = new State();
            states[1].id = 2;
            states[1].stateName = "추격";
            states[2] = new State();
            states[2].id = 3;
            states[2].stateName = "공격";
            states[3] = new State();
            states[3].id = 4;
            states[3].stateName = "죽음";

            transitions[0] = new Transition();
            transitions[0].currentState = 1;
            transitions[0].condition = "적발견";
            transitions[0].nextState = 2;
            transitions[1] = new Transition();
            transitions[1].currentState = 2;
            transitions[1].condition = "적놓침";
            transitions[1].nextState = 1;
            transitions[2] = new Transition();
            transitions[2].currentState = 2;
            transitions[2].condition = "사정거리접근";
            transitions[2].nextState = 3;
            transitions[3] = new Transition();
            transitions[3].currentState = 3;
            transitions[3].condition = "사정거리이탈";
            transitions[3].nextState = 2;
            transitions[4] = new Transition();
            transitions[4].currentState = 3;
            transitions[4].condition = "HP없음";
            transitions[4].nextState = 4;

            int MonsterCurretState = 3;
            string MonsterCondition = "사정거리이탈";
            int MonsterNextState = 0;

            MonsterNextState = transitions[0].Transit(transitions, MonsterCurretState, MonsterCondition);

            for (int i = 0; i < states.Length; ++i)
            {
                if (states[i].id == MonsterNextState)
                {
                    Console.WriteLine(states[i].stateName);
                }
            }
        }
    }
}
