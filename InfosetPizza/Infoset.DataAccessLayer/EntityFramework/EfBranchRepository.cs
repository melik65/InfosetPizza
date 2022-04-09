using Infoset.DataAccessLayer.Abstarct;
using Infoset.DataAccessLayer.Functional;
using Infoset.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Infoset.DataAccessLayer.EntityFramework
{
    public class EfBranchRepository : EfGenericRepository<Branch>, IBrancheDal
    {
        public IEnumerable<Branch> GetFiveBranch(double latitude, double longitude)
        {
            Distance _distance = new Distance(latitude, longitude);
            var branches = GetAll();
            foreach (var item in branches)
            {
                item.distance = _distance.CalcDistance(item.latitude, item.longitude);
            }
            return branches.OrderBy(x => x.distance).Where(x => x.distance <= 10).Take(5);
        }
    }
}
