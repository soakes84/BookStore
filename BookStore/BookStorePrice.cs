using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class BookStorePrice
    {
        public static decimal FinalPrice(Book book)
        {
            return book.Price * 0.025m;
        }
    }
}
