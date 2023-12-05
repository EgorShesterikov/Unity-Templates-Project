using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace State
{
    public class StateMachine : IStateSwitcher, ITickable, IDisposable
    {
        private StateMachineData _data;

        private InputHandler _input;

        private List<IState> _states;
        private IState _currentState;

        public StateMachine(InputHandler input)
        {
            _data = new StateMachineData();

            _input = input;

            _input.ClickedInfo += ReadCountStates;

            _states = new List<IState>()
            {
                new Stay(this, _input, _data),
                new Jump(this, _input, _data),
                new Move(this, _input, _data)
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void Dispose()
        {
            _input.ClickedInfo -= ReadCountStates;
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.Find((state) => state.GetType() == typeof(T));

            if (state != null)
            {
                _currentState.Exit();
                _currentState = state;
                _currentState.Enter();
            }
            else
            {
                throw new System.ArgumentNullException(nameof(state));
            }
        }

        public void Tick()
            => _currentState?.Tick();

        private void ReadCountStates()
            => Debug.Log(_data.HistoryState.Count);
    }
}
