namespace ServiceLocator
{
    public abstract class Audio
    {
        public abstract void PlaySound(int indexSound);
        public abstract void StopSound(int indexSound);
        public abstract void StopAllSounds();
    }
}
