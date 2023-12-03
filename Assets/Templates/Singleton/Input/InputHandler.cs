using System;
using UnityEngine;
using Zenject;

namespace Singleton
{
    public class InputHandler : ITickable
    {
        public event Action ClickedAlpha1;
        public event Action ClickedAlpha2;
        public event Action ClickedAlpha3;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                ClickedAlpha1?.Invoke();

            if (Input.GetKeyDown(KeyCode.Alpha2))
                ClickedAlpha2?.Invoke();

            if (Input.GetKeyDown(KeyCode.Alpha3))
                ClickedAlpha3?.Invoke();
        }
    }
}
