using Infoset.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infoset.BusinessLayer.Abstract
{
    public interface IBranchService : IService<Branch>
    {
        IEnumerable<Branch> GetFive(double latitude, double longitude);
    }
}
