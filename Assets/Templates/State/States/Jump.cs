using System;
using UnityEngine;

namespace State
{
    public class Jump : DefaultState
    {
        public Jump(IStateSwitcher stateSwitcher, InputHandler input, StateMachineData data) : base(stateSwitcher, input, data)
        {
        }

        override public void Enter()
        {
            Debug.Log("Enter in <Jump State>");

            _data.HistoryState.Push(this);

            _input.ClickedSpace += GoToMove;
        }

        override public void Exit()
        {
            Debug.Log("Exit in <Jump State>");

            _input.ClickedSpace -= GoToMove;
        }

        override public void Tick()
        {
            
        }

        private void GoToMove()
            => _stateSwitcher.SwitchState<Move>();
    }

}
