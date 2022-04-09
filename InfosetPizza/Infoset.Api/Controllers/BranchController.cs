using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Infoset.BusinessLayer.Concrete;
using Infoset.DataAccessLayer.EntityFramework;

namespace Infoset.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private BranchManager manager;
        public BranchController()
        {
            manager = new BranchManager(new EfBranchRepository());
        }

        [HttpGet]
        public string GetFive([FromQuery] double latitude, [FromQuery] double longitude)
        {
            return JsonConvert.SerializeObject(manager.GetFive(latitude, longitude));
        }
    }
}
