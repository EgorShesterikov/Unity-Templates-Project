using System;
using UnityEngine;
using Zenject;

namespace Flyweight
{
    public class InputHandler : ITickable
    {
        public event Action SpaceClicked;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SpaceClicked?.Invoke();
        }
    }
}
