using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class BookStore : IBook
    {
        private PageContext _db;

        public BookStore()
        {
            _db = new PageContext();

            // Supposedly there is data on the database
            _db.Pages = new List<Page> {
                new Page { Id = 0, Number = 1, Text = "Page 1" },
                new Page { Id = 1, Number = 2, Text = "Page 2" },
                new Page { Id = 2, Number = 3, Text = "Page 3" }};
        }

        public Page GetPage(int number)
            => _db.Pages.FirstOrDefault(p => p.Number == number);
    }
}
