using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184064
{
    public class Book_1184064: Product_1184064
    {
        protected string pageCount;

        public Book_1184064(string type, string title, string pagecount)
            : base(type, title)
            
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}