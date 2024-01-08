using System;
using UnityEngine;
using Zenject;

namespace ObjectPool
{
    public class InputHandler : ITickable
    {
        public event Action ClickedSpace;
        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                ClickedSpace?.Invoke();
        }
    }
}