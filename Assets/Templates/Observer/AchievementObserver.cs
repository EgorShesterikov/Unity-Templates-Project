using UnityEngine;

namespace Observer
{
    public class AchievementObserver : IObserver
    {
        private int _attackCount;
        private int _jumpCount;
        private int _moveCount;

        public void OnNotify(MassageTypes massage)
        {
            switch (massage)
            {
                case MassageTypes.Attack:
                    _attackCount++;

                    if (_attackCount == 5)
                        Unlock(AchievementTypes.Five_Attack);

                    break;

                case MassageTypes.Jump:
                    _jumpCount++;

                    if(_jumpCount == 5)
                        Unlock(AchievementTypes.Five_Jump);

                    break;

                case MassageTypes.Move:
                    _moveCount++;

                    if (_moveCount == 5)
                        Unlock(AchievementTypes.Five_Move);

                    break;

                default:
                    throw new System.ArgumentOutOfRangeException(nameof(massage));
            }
        }

        private void Unlock(AchievementTypes achievement)
            => Debug.Log($"Open achivement: {achievement}");
    }
}
