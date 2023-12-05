using UnityEngine;

namespace State
{
    public class Move : DefaultState
    {
        public Move(IStateSwitcher stateSwitcher, InputHandler input, StateMachineData data) : base(stateSwitcher, input, data)
        {
        }

        override public void Enter()
        {
            Debug.Log("Enter in <Move State>");

            _data.HistoryState.Push(this);

            _input.ClickedSpace += GoToStay;
        }

        override public void Exit()
        {
            Debug.Log("Exit in <Move State>");

            _input.ClickedSpace -= GoToStay;
        }

        override public void Tick()
        {
            Debug.Log("Hero is move!");
        }

        private void GoToStay()
            => _stateSwitcher.SwitchState<Stay>();
    }

}
