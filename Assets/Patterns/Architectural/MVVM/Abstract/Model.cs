namespace MVVM
{
    public abstract class Model
    {
        public readonly ReactiveProperty<int> Score = new();
    }
}
