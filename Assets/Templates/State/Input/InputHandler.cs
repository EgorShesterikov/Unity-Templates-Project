using System;
using UnityEngine;
using Zenject;

namespace State
{
    public class InputHandler : ITickable
    {
        public event Action ClickedSpace;
        public event Action ClickedInfo;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ClickedSpace?.Invoke();
            if (Input.GetKeyDown(KeyCode.I))
                ClickedInfo?.Invoke();

        }
    }
}
