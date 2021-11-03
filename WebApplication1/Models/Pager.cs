using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pager
    {
        public int totalItem { get; private set; }    // total number of records.
        public int currentPage { get; private set; }    
        public int pageSize { get; private set; }   // how many records can be contained by one page.
        public int totalPage { get; private set; }     // total number of page require to list all the records.
        public int firstPage { get; private set; }   // first page number of page navigator
        public int lastPage { get; private set; }    // last page number of page navigator

        public Pager()
        {

        }

        public Pager(int totalItem, int page, int pageSize = 7)
        {
            this.totalItem = totalItem;
            this.totalPage = (int)Math.Ceiling(totalItem / (double)pageSize);

            int currentPage = page;
            int firstPage = currentPage - 2;
            int lastPage = currentPage + 2;

            if (firstPage <= 0)
            {
                lastPage = lastPage - (firstPage - 1);
                firstPage = 1;
            }

            if (lastPage > totalPage)
            {
                lastPage = totalPage;
                if (lastPage > 5)
                {
                    firstPage = lastPage - 4;
                }         
            }

            this.currentPage = currentPage;
            this.firstPage = firstPage;
            this.lastPage = lastPage;
            this.pageSize = pageSize;
        }
    }
}
