using Infoset.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Infoset.DataAccessLayer.Abstarct
{
    public interface IBrancheDal : IRepositoryDal<Branch>
    {
        IEnumerable<Branch> GetFiveBranch(double latitude, double longitude);
    }
}
