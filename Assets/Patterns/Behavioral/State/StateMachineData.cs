using System.Collections.Generic;

namespace State
{
    public class StateMachineData
    {
        public Stack<IState> HistoryState;

        public StateMachineData()
        {
            HistoryState = new Stack<IState>();
        }
    }
}
