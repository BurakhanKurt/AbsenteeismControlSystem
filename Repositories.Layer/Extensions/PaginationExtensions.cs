using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Extensions
{
    public static class PaginationExtensions
    {
        public static IQueryable<Course> ToPageList(
            this IQueryable<Course> entity,
            int pageNumber,
            int pageSize)
        {
            var pagedList = entity
                .Skip((pageNumber - 1)*pageSize)
                .Take(pageSize);
            return pagedList;
        }
    }
}
