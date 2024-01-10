using System;
using UnityEngine;
using Zenject;

namespace Mediator
{
    public class InputHandler : ITickable
    {
        public event Action ClickedAlpha1;
        public event Action ClickedAlpha2;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                ClickedAlpha1?.Invoke();

            if (Input.GetKeyDown(KeyCode.Alpha2))
                ClickedAlpha2?.Invoke();
        }
    }
}
