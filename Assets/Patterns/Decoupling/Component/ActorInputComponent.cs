using System;
using UnityEngine;

namespace Component
{
    public class ActorInputComponent : InputComponent
    {
        public event Action OnClickedLeft;
        public event Action OnClickedRight;

        public void Update(Actor actor)
        {
            // Input code

            if(Input.GetKeyDown(KeyCode.A))
                OnClickedLeft?.Invoke();

            if(Input.GetKeyDown(KeyCode.D))
                OnClickedRight?.Invoke();
        }
    }
}
