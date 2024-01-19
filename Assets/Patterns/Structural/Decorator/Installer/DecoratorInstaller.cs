using UnityEngine;
using Zenject;

namespace Decorator
{
    public class DecoratorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            Debug.Log(pizza1.Name + " Cost: " + pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);
            Debug.Log(pizza2.Name + " Cost: " + pizza2.GetCost());

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);
            Debug.Log(pizza3.Name + " Cost: " + pizza3.GetCost());
        }
    }
}
