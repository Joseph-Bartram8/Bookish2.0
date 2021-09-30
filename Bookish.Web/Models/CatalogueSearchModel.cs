using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookish_dataAccess;

namespace Bookish.Web.Models
{
    public class CatalogueSearchModel
    {
        public BookSearchModel SearchCriteria { get; private set; }

        public CatalogueSearchModel(BookSearchModel searchCritiria, int page, int totalPages, IEnumerable<Book> books)
        {
            SearchCriteria = searchCritiria;
        }


    }
}