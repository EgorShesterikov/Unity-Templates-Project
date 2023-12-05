using UnityEngine;

namespace State
{
    public class Stay : DefaultState
    {
        public Stay(IStateSwitcher stateSwitcher, InputHandler input, StateMachineData data) : base(stateSwitcher, input, data)
        {
        }

        override public void Enter()
        {
            Debug.Log("Enter in <Stay State>");

            _data.HistoryState.Push(this);

            _input.ClickedSpace += GoToJump;
        }

        override public void Exit()
        {
            Debug.Log("Exit in <Stay State>");

            _input.ClickedSpace -= GoToJump;
        }

        override public void Tick()
        {
            
        }

        private void GoToJump()
            => _stateSwitcher.SwitchState<Jump>();
    }
}
