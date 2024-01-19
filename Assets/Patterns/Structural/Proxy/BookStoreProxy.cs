using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class BookStoreProxy : IBook
    {
        private List<Page> _pages = new List<Page>();
        private BookStore _bookStore;

        public BookStoreProxy()
            => _pages = new List<Page>();

        public Page GetPage(int number)
        {
            Page page = _pages.FirstOrDefault(p => p.Number == number);

            if(page == null)
            {
                if (_bookStore == null)
                    _bookStore = new BookStore();

                page = _bookStore.GetPage(number);
                _pages.Add(page);
            }

            return page;
        }
    }
}
