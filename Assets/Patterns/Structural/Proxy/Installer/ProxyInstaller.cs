using UnityEngine;
using Zenject;

namespace Proxy
{
    public class ProxyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            IBook book = new BookStoreProxy();

            Page page1 = book.GetPage(1);
            Debug.Log(page1.Text);

            Page page2 = book.GetPage(2);
            Debug.Log(page2.Text);

            page1 = book.GetPage(1);
            Debug.Log(page1.Text);
        }
    }
}
