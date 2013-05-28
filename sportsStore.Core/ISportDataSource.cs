using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsStore.Core
{
    public interface ISportDataSource
    {
        IQueryable<Product> Products { get; }
        IQueryable<Sport> Sports { get; }
    }
}
