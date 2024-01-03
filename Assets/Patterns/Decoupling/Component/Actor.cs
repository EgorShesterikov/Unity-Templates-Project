using System;
using UnityEngine;
using Zenject;

namespace Component
{
    public class Actor : ITickable, IDisposable
    {
        private ActorInputComponent _actorInput;
        private ActorPhysicsComponent _actorPhysics;
        private ActorSpriteComponent _actorSprite;

        public Actor(ActorInputComponent actorInput, ActorPhysicsComponent actorPhysics, ActorSpriteComponent actorSprite)
        {
            _actorInput = actorInput;
            _actorPhysics = actorPhysics;
            _actorSprite = actorSprite;

            _actorInput.OnClickedLeft += ReadInput;
            _actorInput.OnClickedRight += ReadInput;
        }

        public void Dispose()
        {
            _actorInput.OnClickedLeft -= ReadInput;
            _actorInput.OnClickedRight -= ReadInput;
        }

        public void Tick()
        {
            _actorInput.Update(this);
            _actorPhysics.Update(this);
            _actorSprite.Update(this);
        }

        private void ReadInput()
            => Debug.Log("Control input is noticed");
    }
}
