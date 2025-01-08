using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Scheduler.Controller;
using Microsoft.AspNetCore.Mvc;

namespace yktest.Schedulers.Controller
{
    [Route("apps/yktest/latest/api/Scheduler/[action]")]
    [Route("apps/yktest/{v:int:min(1)}/api/Scheduler/[action]")]
    [Route("api/Scheduler/[action]")]
    [Produces("application/json")]
    public class SchedulerController : BaseSchedulerController
    {
        public SchedulerController(IIocManager iocManager) : base(iocManager)
        {
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Scheduler API Controller is ok";
        }
    }
}