using System;
using UnityEngine;
using Zenject;

namespace EventQueue
{
    public class InputHandler : ITickable
    {
        public event Action ClickedQ;
        public event Action ClickedW;
        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                ClickedQ?.Invoke();

            if (Input.GetKeyDown(KeyCode.W))
                ClickedW?.Invoke();
        }
    }
}