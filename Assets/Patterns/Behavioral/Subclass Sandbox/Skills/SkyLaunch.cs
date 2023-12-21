using Zenject;

namespace SubclassSandbox
{
    public class SkyLaunch : Superpower, IInitializable
    {
        public void Initialize()
            => Activate();

        protected override void Activate() 
        {
            SoundPlayer.PlaySound(0, 100);
            SpawnParticles(0, 5);
            Move(0, 0, 20);
        }
    }
}
