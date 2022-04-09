using Infoset.BusinessLayer.Abstract;
using Infoset.DataAccessLayer.Abstarct;
using Infoset.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoset.BusinessLayer.Concrete
{
    public class BranchManager : Manager<Branch>, IBranchService
    {
        IBrancheDal dal;
        public BranchManager(IBrancheDal _dal) : base(_dal)
        {
            dal = _dal;
        }

        public IEnumerable<Branch> GetFive(double latitude, double longitude)
        {
            return dal.GetFiveBranch(latitude, longitude);
        }
    }
}
