using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
    public class PageListParameters
    {
        private int pageSize = 5;
        public int PageSize 
        {
            get { return pageSize; } 
            set { pageSize = value>pageSize ? pageSize : value; } 
        }
        public int PageNumber { get; set; } = 1;
    }
}
