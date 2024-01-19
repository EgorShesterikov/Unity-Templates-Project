using System;
using UnityEngine;
using Zenject;

namespace AbstractFactory
{
    public class InputHandler : ITickable
    {
        public event Action ClickedSpace;
        public event Action ClickedLBM;
        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ClickedSpace?.Invoke();

            if (Input.GetKeyDown(KeyCode.Mouse0))
                ClickedLBM?.Invoke();
        }
    }
}
