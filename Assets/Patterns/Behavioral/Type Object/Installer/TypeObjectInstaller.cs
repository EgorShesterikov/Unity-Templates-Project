using UnityEngine;
using Zenject;

namespace TypeObject
{
    public class TypeObjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Breed wars = new Breed(null, 5, 5);
            Breed strongWars = new Breed(wars, 0, 7);

            //Breed archer = new Breed(null, 3, 7);
            //Breed mag = new Breed(null, 4, 6);

            Monster monster = strongWars.NewMonster();

            Debug.Log($"Monster info: \n " +
                $"Health: {monster.CurrentHealth} \n " +
                $"Attack: {monster.Attack}");
        }
    }
}
