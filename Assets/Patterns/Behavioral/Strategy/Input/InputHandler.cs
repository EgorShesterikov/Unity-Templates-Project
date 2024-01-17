using System;
using UnityEngine;
using Zenject;

namespace Strategy
{
    public class InputHandler : ITickable
    {
        public event Action ClickedSpace;

        public event Action ClickedAlpha1;
        public event Action ClickedAlpha2;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ClickedSpace?.Invoke();

            if (Input.GetKeyDown(KeyCode.Alpha1))
                ClickedAlpha1?.Invoke();

            if (Input.GetKeyDown(KeyCode.Alpha2))
                ClickedAlpha2?.Invoke();
        }
    }
}
